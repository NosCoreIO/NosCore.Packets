//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets
{
    public class Serializer : ISerializer
    {
        private readonly Dictionary<Type, PacketWriter> _packetSerializerDictionary = new Dictionary<Type, PacketWriter>();

        // A chat prefix ("/name text", ":text", ";text") is the start of its line's first word.
        private sealed record PacketWriter(Func<IPacket, bool, object> Write, bool IsChatPrefix);

        public Serializer(IEnumerable<Type> types)
        {
            var serializerMethod = typeof(Serializer).GetMethod(nameof(Initialize));
            foreach (var type in types)
            {
                serializerMethod!.MakeGenericMethod(type).Invoke(this, null);
            }
        }

        public void Initialize<T>() where T : PacketBase
        {
            var header = typeof(T).GetCustomAttribute<PacketHeaderAttribute>()?.Identification;
            if (string.IsNullOrEmpty(header))
            {
                return;
            }

            _packetSerializerDictionary[typeof(T)] = new PacketWriter(PacketSerializerExpression<T>(header).Compile(), header is "/" or ":" or ";");
        }

        public string Serialize(IPacket packet)
        {
            var writer = _packetSerializerDictionary[packet.GetType()];
            var fullString = (string)writer.Write(packet, false);
            if (writer.IsChatPrefix && fullString.Length > 1 && fullString[1] == ' ')
            {
                fullString = fullString.Remove(1, 1);
            }

            return fullString;
        }

        // RemoveHash writes the packet inline as a line of its own ("e_info 7 4240 ...") instead of "#e_info^7^4240".
        private string? SerializeInjected(IPacket? value, bool inline, bool isOptional) =>
            value == null
                ? isOptional ? null : "-1"
                : (string)_packetSerializerDictionary[value.GetType()].Write(value, !inline);

        public string Serialize(IEnumerable<IPacket> packets)
        {
            return string.Join('\uffff', packets.Select(Serialize));
        }

        private Expression DefaultSerializer(Expression specificTypeExpression, Expression splitter)
        {
            // A number is written with its own ToString rather than boxed for string.Concat to call it.
            if (specificTypeExpression.Type.IsPrimitive)
            {
                specificTypeExpression = Expression.Call(specificTypeExpression,
                    specificTypeExpression.Type.GetMethod(nameof(ToString), Type.EmptyTypes)!);
            }

            return ConcatExpression(splitter, specificTypeExpression);
        }

        private Expression StringSerializer(Expression exp, bool isLastIndex, bool isOptional, Expression splitter,
            Expression escapeSeparator, bool isNested, bool escapeSpaces, string spaceEscape)
        {
            var replaceMethod = typeof(string).GetMethod("Replace", new[] { typeof(string), typeof(string) })!;

            Expression escaped = exp;
            if (escapeSpaces)
            {
                escaped = Expression.Call(escaped, replaceMethod,
                    Expression.Constant(" ", typeof(string)),
                    Expression.Constant(spaceEscape, typeof(string)));
            }

            escaped = Expression.Call(escaped, replaceMethod,
                Expression.Convert(escapeSeparator, typeof(string)),
                Expression.Constant("^", typeof(string)));

            // A nested value also sits inside a field of the packet above it.
            if (isNested)
            {
                escaped = Expression.Call(escaped, replaceMethod,
                    Expression.Constant(" ", typeof(string)),
                    Expression.Constant("^", typeof(string)));
            }

            var replace = escaped;

            var nullOrEmpty = Expression.Call(null,
                typeof(string).GetMethod("IsNullOrEmpty", new[] { typeof(string) })!,
                Expression.Convert(escapeSeparator, typeof(string))
            );

            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                isOptional ? Expression.Constant(null) : ConcatExpression(splitter, Expression.Constant("-")),
                ConcatExpression(splitter,
                    Expression.Condition(nullOrEmpty,
                        Expression.Convert(exp, typeof(object)),
                        Expression.Convert(isLastIndex && !escapeSpaces ? exp : replace, typeof(object))))
            );
        }

        private Expression NullableSerializer(Expression exp, bool isOptional, Expression splitter)
        {
            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                isOptional
                    ? Expression.Constant(null, typeof(object))
                    : ConcatExpression(splitter, Expression.Constant("-1")),
                ConcatExpression(splitter, exp)
            );
        }

        private Expression EnumSerializer(Expression exp, Expression splitter)
        {
            var expObject = Expression.Convert(Expression.Convert(exp, typeof(long?)), typeof(object));
            return Expression.Condition(
                Expression.Equal(expObject, Expression.Default(typeof(object))),
                expObject,
                ConcatExpression(splitter, expObject));
        }

        private Expression ConcatExpression(Expression left, Expression right)
        {
            return Expression.Convert(Expression.Call(
                typeof(string).GetMethod("Concat", new[] { typeof(object), typeof(object) })!,
                Expression.Convert(left, typeof(object)),
                Expression.Convert(right, typeof(object))), typeof(object));
        }

        private Expression BooleanSerializer(Expression exp, Expression splitter)
        {
            var falseSplitter = ConcatExpression(splitter, Expression.Constant("0"));

            var trueSplitter = ConcatExpression(splitter, Expression.Constant("1"));

            var expbool = Expression.Convert(exp, typeof(bool?));

            var isFalse = Expression.Condition(
                Expression.Equal(expbool, Expression.Constant(false, typeof(bool?))),
                falseSplitter,
                trueSplitter
                , typeof(object));

            return Expression.Condition(Expression.Equal(expbool, Expression.Constant(null, typeof(object))),
                Expression.Convert(exp, typeof(object)),
                isFalse);
        }

        private static IEnumerable<T> PadToMinimumLength<T>(IEnumerable<T>? source, int minimum) where T : new()
        {
            var list = source?.ToList() ?? new List<T>();
            while (list.Count < minimum)
            {
                list.Add(new T());
            }
            return list;
        }

        private Expression ListSerializer(Expression injectedPacket, Expression specificTypeExpression,
            PacketIndexAttribute indexAttr, Type type, string packetSplitter, Expression propertySplitter)
        {
            var subtype = type.GenericTypeArguments.Any() ? type.GenericTypeArguments[0] : type.GetElementType() ?? typeof(object);
            if (subtype == typeof(object))
            {
                packetSplitter = " ";
            }
            var param = Expression.Parameter(subtype!);
            var isOptional = indexAttr.IsOptional;
            var isPacketList = false;
            if (typeof(IPacket).IsAssignableFrom(subtype))
            {
                indexAttr.IsOptional = false;
                isPacketList = true;
            }

            if (indexAttr is PacketListIndexAttribute padIndex && padIndex.Length > 0
                && subtype != typeof(object)
                && subtype!.GetConstructor(Type.EmptyTypes) != null)
            {
                var padMethod = typeof(Serializer).GetMethod(nameof(PadToMinimumLength),
                    BindingFlags.NonPublic | BindingFlags.Static)!.MakeGenericMethod(subtype);
                specificTypeExpression = Expression.Call(padMethod,
                    specificTypeExpression,
                    Expression.Constant((int)padIndex.Length));
            }

            var selectExp = Expression.Call(
                typeof(Enumerable),
                "Select",
                new[] { subtype, typeof(string) }!,
                specificTypeExpression,
                Expression.Lambda(
                    Expression.Convert(isPacketList
                        ? PacketSerializer(injectedPacket, indexAttr, param, subtype!, 0, propertySplitter, "", true)
                        : PropertySerializer(injectedPacket, indexAttr, subtype!, param, 0,
                            Expression.Constant(""), Expression.Constant("")), typeof(string)), param)
            );

            var listJoin = Expression.Convert(Expression.Call(
                    typeof(string).GetMethod("Join", new[] { typeof(string), typeof(IEnumerable<string>) })!,
                    isPacketList || indexAttr is PacketListIndexAttribute ? Expression.Constant(packetSplitter, typeof(string)) : propertySplitter,
                    selectExp),
                typeof(object));

            Expression isAbsent = Expression.Equal(specificTypeExpression, Expression.Constant(null, typeof(object)));
            if (isOptional)
            {
                isAbsent = Expression.OrElse(isAbsent, Expression.Equal(
                    Expression.Property(Expression.Convert(specificTypeExpression, typeof(System.Collections.ICollection)), "Count"),
                    Expression.Constant(0)));
            }

            return Expression.Condition(
                isAbsent,
                Expression.Constant(null, typeof(object)),
                ConcatExpression(Expression.Constant(indexAttr.SpecialSeparator != null ? " " : string.Empty), Expression.Convert(listJoin, typeof(object)))
            );
        }

        private Expression PacketSerializer(Expression injectedPacket, PacketIndexAttribute indexAttr, Expression specificTypeExpression, Type prop,
            int maxIndex, Expression propertySplitter, string discriminator, bool isFromList = false)
        {
            // Every field's text is one argument of a single string.Concat, rather than each one being
            // appended to a new copy of the line so far.
            var pieces = new List<Expression>
            {
                Expression.Condition(injectedPacket, Expression.Constant($"#{discriminator}"),
                    Expression.Constant(discriminator, typeof(string))),
            };

            Expression incrementExpr = Expression.Condition(
                Expression.Equal(propertySplitter, Expression.Constant(" ", typeof(string))),
                Expression.Constant(!string.IsNullOrWhiteSpace(discriminator)),
                Expression.Constant(false));
            // Only optional fields ahead of the first required one can be left out without a separator; a later
            // optional run is still written out field by field ("0.0.21.0.6", not "0.0.2106").
            var leadingOptional = true;
            foreach (var (property, index) in IndexedProperties(prop))
            {
                leadingOptional = leadingOptional && index.IsOptional;

                var splitter = Expression.Condition(injectedPacket,
                    Expression.Constant("^", typeof(object)),
                    index.SpecialSeparator != null
                        // A value field writes its own separator ("vnum.current/total"); a nested sub-packet does not.
                        ? Expression.Constant(typeof(PacketBase).IsAssignableFrom(property.PropertyType)
                            ? indexAttr.SpecialSeparator ?? string.Empty
                            : string.Empty, typeof(object))
                        : (Expression)Expression.Convert(propertySplitter, typeof(object)));

                // Held in a variable so that a nested sub-packet is written once, not once per test of its result.
                var exp = Expression.Variable(typeof(object));
                var written = Expression.Convert(
                    PropertySerializer(injectedPacket,
                        index,
                        property.PropertyType,
                        Expression.Property(specificTypeExpression, property.Name),
                        maxIndex,
                        Expression.Condition(injectedPacket, Expression.Constant(string.Empty, typeof(object)),
                            Expression.Constant(index.SpecialSeparator, typeof(object))),
                        index.SpecialSeparator != null
                            ? Expression.Constant(index.SpecialSeparator, typeof(object))
                            : splitter,
                        isFromList)
                    , typeof(object));

                var trimfirst = Expression.Condition(
                    Expression.Equal(incrementExpr, Expression.Constant(false)),
                    exp,
                    ConcatExpression(splitter, exp));

                var trimnull = Expression.Condition(
                    Expression.Equal(exp, Expression.Constant(null, typeof(string))),
                    Expression.Constant(string.Empty, typeof(object)),
                    trimfirst);

                pieces.Add(Expression.Block(new[] { exp }, new Expression[] { Expression.Assign(exp, written), trimnull }));

                incrementExpr = Expression.Constant(!isFromList || !leadingOptional);
            }

            // A sub-packet with its own separator is written after a single-space discriminator; an absent one
            // keeps that space, or "13458 -1 -1" (sc_n with no equipment) runs together as "13458-1-1".
            return Expression.Condition(
                Expression.Equal(specificTypeExpression, Expression.Constant(null, typeof(object))),
                Expression.Constant(indexAttr.IsOptional ? null : discriminator == " " ? " -1" : "-1", typeof(object)),
                Expression.Convert(Expression.Call(StringConcat, Expression.NewArrayInit(typeof(object),
                    pieces.Select(piece => Expression.Convert(piece, typeof(object))))), typeof(object))
            );
        }

        private static readonly MethodInfo StringConcat = typeof(string).GetMethod(nameof(string.Concat), new[] { typeof(object[]) })!;

        // The indexed properties of a type in index order, each with a PacketIndexAttribute instance of its own.
        private static IEnumerable<(PropertyInfo Property, PacketIndexAttribute Index)> IndexedProperties(Type type) =>
            type.GetProperties()
                .Select(property => (Property: property, Index: property.GetCustomAttributes(true).OfType<PacketIndexAttribute>().FirstOrDefault()))
                .Where(field => field.Index != null)
                .OrderBy(field => field.Index!.Index)
                .Select(field => (field.Property, field.Index!));

        private Expression<Func<IPacket, bool, object>> PacketSerializerExpression<T>(string header) where T : PacketBase
        {
            var maxIndex = IndexedProperties(typeof(T)).Select(field => field.Index.Index).LastOrDefault();
            var packet = Expression.Parameter(typeof(IPacket));
            var typed = Expression.Variable(typeof(T));
            var injectedPacket = Expression.Parameter(typeof(bool));
            return Expression.Lambda<Func<IPacket, bool, object>>(
                Expression.Block(new[] { typed }, new Expression[]
                {
                    Expression.Assign(typed, Expression.Convert(packet, typeof(T))),
                    Expression.Convert(
                        PacketSerializer(injectedPacket, new PacketIndexAttribute(0), typed, typeof(T), maxIndex, Expression.Constant(" "), header),
                        typeof(object)),
                }),
                packet, injectedPacket);
        }

        private Expression PropertySerializer(Expression injectedPacket, PacketIndexAttribute indexAttr, Type type,
            Expression specificTypeExpression, int maxIndex, Expression propertySplitter, Expression escapeSeparator,
            bool isNested = false)
        {
            var useCustomSerializer = true;
            switch (type)
            {
                //handle boolean
                case var t when (t == typeof(bool)) || (t == typeof(bool?)):
                    specificTypeExpression = BooleanSerializer(specificTypeExpression, propertySplitter);
                    break;
                //handle enum
                case var t when (t.BaseType?.Equals(typeof(Enum)) ?? false) ||
                    (Nullable.GetUnderlyingType(t)?.IsEnum ?? false):
                    // A nullable enum gets its separator from the nullable wrapper below.
                    specificTypeExpression = EnumSerializer(specificTypeExpression,
                        Nullable.GetUnderlyingType(t) != null ? Expression.Constant(null, typeof(string)) : propertySplitter);
                    break;
                //handle list
                case var t when t.GetInterface("System.Collections.ICollection") != null:
                    var splitter = indexAttr is PacketListIndexAttribute ind
                        ? ind.ListSeparator ?? (typeof(IPacket).IsAssignableFrom(t.GenericTypeArguments.Any() ? t.GenericTypeArguments[0] : t.GetElementType()) ? " " : ".")
                        : indexAttr.SpecialSeparator ?? " ";
                    specificTypeExpression = ListSerializer(injectedPacket, specificTypeExpression, indexAttr, t, splitter,
                        Expression.Constant(typeof(IPacket).IsAssignableFrom(t.GenericTypeArguments.Any() ? t.GenericTypeArguments[0] : t.GetElementType())
                            ? indexAttr.SpecialSeparator ?? "."
                            : indexAttr.SpecialSeparator ?? " "));
                    break;
                //handle string
                case var t when t == typeof(string):
                    specificTypeExpression = StringSerializer(specificTypeExpression, indexAttr.Index == maxIndex,
                        indexAttr.IsOptional, propertySplitter, escapeSeparator, isNested,
                        indexAttr.EscapeSpaces, indexAttr.SpaceEscape);
                    break;
                //IPacket declared type
                case var t when typeof(IPacket).IsAssignableFrom(t) && (t != typeof(IPacket)):
                    var header = specificTypeExpression.Type.GetCustomAttribute<PacketHeaderAttribute>()
                        ?.Identification;
                    propertySplitter = Expression.Constant(indexAttr.SpecialSeparator ?? (header == null ? " " : "."));
                    if (!string.IsNullOrEmpty(header))
                    {
                        header = $"{(indexAttr.RemoveHash ? "" : "#")}{header}{(indexAttr.RemoveHash ? " " : "")}";
                        propertySplitter = Expression.Constant(indexAttr.SpecialSeparator ?? "^");
                    }

                    if (header == null && indexAttr.SpecialSeparator != null)
                    {
                        header = " ";
                    }

                    // A sub-packet's fields are numbered from its own zero, so the parent's
                    // maxIndex would mark whichever field happens to share that number as last.
                    var subMaxIndex = IndexedProperties(t).Select(field => field.Index.Index).DefaultIfEmpty(0).Max();

                    specificTypeExpression = PacketSerializer(injectedPacket, indexAttr, specificTypeExpression, t, subMaxIndex,
                        propertySplitter, indexAttr.RemoveHeader ? "" : header ?? "");
                    break;
                case var t when t == typeof(IPacket):
                    // A field declared as IPacket can hold any packet, so its serializer is looked up from the value.
                    specificTypeExpression = Expression.Call(Expression.Constant(this),
                        typeof(Serializer).GetMethod(nameof(SerializeInjected), BindingFlags.NonPublic | BindingFlags.Instance)!,
                        Expression.Convert(specificTypeExpression, typeof(IPacket)),
                        Expression.Constant(indexAttr.RemoveHash), Expression.Constant(indexAttr.IsOptional));
                    break;
                default:
                    useCustomSerializer = false;
                    break;
            }

            if ((type != typeof(string)) && (Nullable.GetUnderlyingType(type) != null))
            {
                specificTypeExpression =
                    NullableSerializer(specificTypeExpression, indexAttr.IsOptional, propertySplitter);
                useCustomSerializer = true;
            }

            if (!useCustomSerializer)
            {
                specificTypeExpression = DefaultSerializer(specificTypeExpression, propertySplitter);
            }

            return specificTypeExpression;
        }
    }
}