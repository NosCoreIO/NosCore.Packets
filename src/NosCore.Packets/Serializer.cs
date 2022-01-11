//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets
{
    public class Serializer : ISerializer
    {
        private const string InjectionKey = "IPacketToInject";

        private readonly Dictionary<string, Delegate> _packetSerializerDictionary = new Dictionary<string, Delegate>();


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
            var packetSerializerExpressionFalse = PacketSerializerExpression<T>();
            if (packetSerializerExpressionFalse != null)
            {
                if (_packetSerializerDictionary.ContainsKey(typeof(T).Name))
                {
                    if (typeof(T).Namespace!.Contains("ClientPackets"))
                    {
                        return;
                    }

                    _packetSerializerDictionary.Remove(typeof(T).Name);
                }
                _packetSerializerDictionary.Add(typeof(T).Name, packetSerializerExpressionFalse.Compile());
            }
        }

        public string Serialize(IPacket packet)
        {
            var realType = packet.GetType();
            var deg = _packetSerializerDictionary[packet.GetType().Name];
            var fullString = (string)deg.DynamicInvoke(packet, false)!;
            if (fullString.Contains(InjectionKey))
            {
                //unfortunately some packets like DLG, DELAY can handle multiple type packet we can't build the full serializer at init, instead we inject serializer with reflection
                foreach (var prop in realType.GetProperties().Where(p => p.PropertyType == typeof(IPacket)))
                {
                    var place = fullString.IndexOf(InjectionKey, StringComparison.Ordinal);
                    var value = realType.GetProperty(prop.Name)!.GetValue(packet, null);
                    fullString = fullString
                        .Remove(place, InjectionKey.Length)
                        .Insert(place,
                            (string)_packetSerializerDictionary[value!.GetType().Name].DynamicInvoke(value, true)!);
                }
            }

            return fullString;
        }

        public string Serialize(IEnumerable<IPacket> packets)
        {
            return string.Join('\uffff'.ToString(), packets.Select(Serialize));
        }

        private Expression DefaultSerializer(Expression specificTypeExpression, Expression splitter)
        {
            return ConcatExpression(splitter, specificTypeExpression);
        }

        private Expression StringSerializer(Expression exp, bool isLastIndex, bool isOptional, Expression splitter)
        {
            var replace = Expression.Call(exp,
                typeof(string).GetMethod("Replace", new[] { typeof(string), typeof(string) })!,
                Expression.Convert(splitter, typeof(string)),
                Expression.Constant("^", typeof(string))
            );

            var nullOrEmpty = Expression.Call(null,
                typeof(string).GetMethod("IsNullOrEmpty", new[] { typeof(string) })!,
                Expression.Convert(splitter, typeof(string))
            );

            return Expression.Condition(
                Expression.Equal(exp, Expression.Constant(null, typeof(object))),
                isOptional ? Expression.Constant(null) : ConcatExpression(splitter, Expression.Constant("-")),
                ConcatExpression(splitter,
                    Expression.Condition(nullOrEmpty,
                        Expression.Convert(exp, typeof(object)),
                        Expression.Convert(isLastIndex ? exp : replace, typeof(object))))
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

        private Expression ListSerializer(Expression injectedPacket, Expression specificTypeExpression,
            PacketIndexAttribute indexAttr, Type type, string packetSplitter, Expression propertySplitter)
        {
            var subtype = type.GenericTypeArguments.Any() ? type.GenericTypeArguments[0] : type.GetElementType() ?? typeof(object);
            if (subtype == typeof(object))
            {
                packetSplitter = " ";
            }
            var param = Expression.Parameter(subtype!);
            var isPacketList = false;
            if (typeof(IPacket).IsAssignableFrom(subtype))
            {
                indexAttr.IsOptional = false;
                isPacketList = true;
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
                            Expression.Constant("")), typeof(string)), param)
            );

            var listJoin = Expression.Convert(Expression.Call(
                    typeof(string).GetMethod("Join", new[] { typeof(string), typeof(IEnumerable<string>) })!,
                    isPacketList || indexAttr is PacketListIndexAttribute ? Expression.Constant(packetSplitter, typeof(string)) : propertySplitter,
                    selectExp),
                typeof(object));

            return Expression.Condition(
                Expression.Equal(specificTypeExpression, Expression.Constant(null, typeof(object))),
                Expression.Constant(null, typeof(object)),
                ConcatExpression(Expression.Constant(indexAttr.SpecialSeparator != null ? " " : string.Empty), Expression.Convert(listJoin, typeof(object)))
            );
        }

        private Expression PacketSerializer(Expression injectedPacket, PacketIndexAttribute indexAttr, Expression specificTypeExpression, Type prop,
            int maxIndex, Expression propertySplitter, string discriminator, bool isFromList = false)
        {
            var properties = prop.GetProperties()
                .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index).ToList();

            Expression propExp = Expression.Condition(injectedPacket, Expression.Constant($"#{discriminator}"),
                Expression.Constant(discriminator, typeof(string)));

            Expression incrementExpr = Expression.Condition(
                Expression.Equal(propertySplitter, Expression.Constant(" ", typeof(string))),
                Expression.Constant(!string.IsNullOrWhiteSpace(discriminator)),
                Expression.Constant(false));
            var startserie = true;
            var isOptionalSerie = false;
            foreach (var property in properties)
            {
                var index = property.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First();
                if (startserie && index.IsOptional)
                {
                    isOptionalSerie = true;
                }
                else
                {
                    startserie = index.IsOptional;
                    isOptionalSerie = false;
                }

                var exp = Expression.Convert(
                    PropertySerializer(injectedPacket,
                        index,
                        property.PropertyType,
                        Expression.Property(specificTypeExpression, property.Name),
                        maxIndex,
                        Expression.Condition(injectedPacket, Expression.Constant(string.Empty, typeof(object)),
                            Expression.Constant(index.SpecialSeparator, typeof(object))))
                    , typeof(object));

                var splitter = Expression.Condition(injectedPacket,
                    Expression.Constant("^", typeof(object)),
                    index.SpecialSeparator != null
                        ? Expression.Constant(indexAttr.SpecialSeparator ?? string.Empty, typeof(object))
                        : (Expression)Expression.Convert(propertySplitter, typeof(object)));

                var trimfirst = Expression.Condition(
                    Expression.Equal(incrementExpr, Expression.Constant(false)),
                    exp,
                    ConcatExpression(splitter, exp));

                var trimnull = Expression.Condition(
                    Expression.Equal(exp, Expression.Constant(null, typeof(string))),
                    Expression.Constant(string.Empty, typeof(object)),
                    trimfirst);

                propExp = ConcatExpression(propExp, trimnull);

                incrementExpr = Expression.Constant(!isFromList || !isOptionalSerie);
            }

            return Expression.Condition(
                Expression.Equal(specificTypeExpression, Expression.Constant(null, typeof(object))),
                Expression.Constant(indexAttr.IsOptional ? null : "-1", typeof(object)),
                Expression.Convert(propExp, typeof(object))
            );
        }

        private LambdaExpression? PacketSerializerExpression<T>() where T : PacketBase
        {
            var header = typeof(T).GetCustomAttribute<PacketHeaderAttribute>()?.Identification;

            if (string.IsNullOrEmpty(header))
            {
                return null;
            }

            var properties = typeof(T).GetProperties()
                .Where(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(x => x.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index).ToList();
            var maxIndex = properties.LastOrDefault()?.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First()
                .Index ?? 0;
            var param = Expression.Parameter(typeof(T));
            var injectedPacket = Expression.Parameter(typeof(bool));
            return Expression.Lambda(
                Expression.Convert(
                    PacketSerializer(injectedPacket, new PacketIndexAttribute(0), param, typeof(T), maxIndex, Expression.Constant(" "), header),
                    typeof(object)), param, injectedPacket);
        }

        private Expression PropertySerializer(Expression injectedPacket, PacketIndexAttribute indexAttr, Type type,
            Expression specificTypeExpression, int maxIndex, Expression propertySplitter)
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
                    specificTypeExpression = EnumSerializer(specificTypeExpression, propertySplitter);
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
                        indexAttr.IsOptional, propertySplitter);
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

                    specificTypeExpression = PacketSerializer(injectedPacket, indexAttr, specificTypeExpression, t, maxIndex,
                        propertySplitter, indexAttr.RemoveHeader ? "" : header ?? "");
                    break;
                case var t when t == typeof(IPacket):
                    specificTypeExpression = Expression.Constant(InjectionKey, typeof(string));
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