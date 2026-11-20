//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets
{
    // What a packet type's attributes say about its fields, read once per type instead of once per line.
    internal sealed class PacketLayout
    {
        private static readonly ConcurrentDictionary<Type, PacketLayout> Layouts = new();

        private PacketLayout(Type type)
        {
            var properties = type.GetProperties();
            Fields = properties
                .Select(property => (Property: property, Index: property.GetCustomAttributes(true).OfType<PacketIndexAttribute>().FirstOrDefault()))
                .Where(field => field.Index != null)
                .OrderBy(field => field.Index!.Index)
                .Select(field => new PacketField(type, field.Property, field.Index!))
                .ToArray();
            MaxIndex = Fields.Length == 0 ? 0 : Fields.Max(field => field.Index.Index);
            HasHeader = type.GetCustomAttribute<PacketHeaderAttribute>() != null;

            var required = 0;
            for (var position = Fields.Length - 1; position >= 0; position--)
            {
                Fields[position].RequiredAfter = required;
                required += Fields[position].Index.IsOptional ? 0 : 1;
            }

            JoinSeparators = Fields
                .Select(field => field.Index)
                .Where(index => index is { Index: > 0 } && !string.IsNullOrEmpty(index.SpecialSeparator) && index.SpecialSeparator != " ")
                .Select(index => index.SpecialSeparator!)
                .ToArray();
            ValueSeparators = properties
                .Where(property => !typeof(IPacket).IsAssignableFrom(property.PropertyType))
                .Select(property => property.GetCustomAttribute<PacketIndexAttribute>()?.SpecialSeparator)
                .OfType<string>()
                .Where(separator => separator.Length > 0 && separator != " ")
                .Distinct()
                .ToArray();
            LeftOutCandidates = Fields
                .Where(field => field.Index.IsOptional && field.Index.Index != MaxIndex && field.IsScalar)
                .Select(field => field.Name)
                .ToArray();
        }

        public static PacketLayout Of(Type type) => Layouts.GetOrAdd(type, static type => new PacketLayout(type));

        // The indexed properties, in index order.
        public PacketField[] Fields { get; }

        public int MaxIndex { get; }

        public bool HasHeader { get; }

        // The separators a field after the first names for itself ("id|experience"), which mark a sub-packet
        // written as one token.
        public string[] JoinSeparators { get; }

        // The separators a value field names for itself ("vnum.current/total"), in declaration order.
        public string[] ValueSeparators { get; }

        // The optional fields that a line may leave out ahead of the last one.
        public string[] LeftOutCandidates { get; }

        // A sub-packet written as one token joins its fields with the list's separator, or with the
        // separator a field names for itself (gexp's "id|experience").
        public bool IsJoined(string token, string listSeparator)
        {
            if (token.Contains(listSeparator, StringComparison.Ordinal))
            {
                return true;
            }

            foreach (var separator in JoinSeparators)
            {
                if (token.Contains(separator, StringComparison.Ordinal))
                {
                    return true;
                }
            }

            return false;
        }
    }

    internal enum FieldKind
    {
        Text,
        Guid,
        Boolean,
        Enumeration,
        Arguments,
        Array,
        List,
        AnyPacket,
        SubPacket,
        Value,
    }

    internal sealed class PacketField
    {
        private PacketLayout? _layout;
        private PacketLayout? _elementLayout;
        private Func<IEnumerable<object?>, object>? _fillList;

        public PacketField(Type packetType, PropertyInfo property, PacketIndexAttribute index)
        {
            Property = property;
            Name = property.Name;
            Type = property.PropertyType;
            Index = index;
            Underlying = Nullable.GetUnderlyingType(Type);
            Kind = KindOf(Type);
            var scalar = Underlying ?? Type;
            IsScalar = scalar.IsEnum || scalar.IsPrimitive || scalar == typeof(Guid);
            AcceptsNull = Underlying != null || !Type.IsValueType;
            Default = Type.GetDefaultValue();
            JoinedSeparator = index is not PacketListIndexAttribute && (IsScalar || Type == typeof(string))
                && index.SpecialSeparator is { Length: > 0 } separator && !separator.Any(char.IsWhiteSpace)
                    ? separator
                    : null;
            SubPacketSeparator = index is PacketListIndexAttribute list ? list.ListSeparator : index.SpecialSeparator;
            ElementType = Type.GetElementType() ?? (Type.GetGenericArguments() is { Length: > 0 } arguments ? arguments[0] : null);

            if (Kind == FieldKind.Enumeration)
            {
                var enumType = Underlying ?? Type;
                MinusOneIsDefault = !(Enum.TryParse(enumType, "-1", out var minusOne) && Enum.IsDefined(enumType, minusOne!));
            }

            if (property.GetCustomAttribute<PacketPresentWhenAttribute>() is { } presentWhen)
            {
                PresentWhen = new FieldCondition(packetType, presentWhen.Field, presentWhen.Values);
            }

            if (Type == typeof(Game18NArguments) && property.GetCustomAttribute<PacketFreeTextWhenAttribute>() is { } freeTextWhen)
            {
                FreeTextWhen = new FieldCondition(packetType, freeTextWhen.Field, freeTextWhen.Values);
            }
        }

        public PropertyInfo Property { get; }

        public string Name { get; }

        public Type Type { get; }

        public Type? Underlying { get; }

        public PacketIndexAttribute Index { get; }

        public FieldKind Kind { get; }

        public bool IsScalar { get; }

        public bool AcceptsNull { get; }

        public object? Default { get; }

        public bool MinusOneIsDefault { get; }

        // A field written with its own separator rides on the token before it ("familyId.title").
        public string? JoinedSeparator { get; }

        public string? SubPacketSeparator { get; }

        public Type? ElementType { get; }

        public FieldCondition? PresentWhen { get; }

        public FieldCondition? FreeTextWhen { get; }

        // How many of the fields after this one the line cannot leave out.
        public int RequiredAfter { get; set; }

        public PacketLayout ElementLayout => _elementLayout ??= PacketLayout.Of(ElementType!);

        public PacketLayout Layout => _layout ??= PacketLayout.Of(Type);

        public Func<IEnumerable<object?>, object> FillList => _fillList ??= ElementType!.GetAndFillListMethod();

        private static FieldKind KindOf(Type type) => type switch
        {
            _ when type == typeof(string) => FieldKind.Text,
            _ when type == typeof(Guid) || type == typeof(Guid?) => FieldKind.Guid,
            _ when type == typeof(bool) || type == typeof(bool?) => FieldKind.Boolean,
            _ when type.BaseType == typeof(Enum) || (Nullable.GetUnderlyingType(type)?.IsEnum ?? false) => FieldKind.Enumeration,
            _ when type == typeof(Game18NArguments) => FieldKind.Arguments,
            { IsArray: true } => FieldKind.Array,
            _ when typeof(ICollection).IsAssignableFrom(type) => FieldKind.List,
            _ when type == typeof(IPacket) => FieldKind.AnyPacket,
            _ when typeof(IPacket).IsAssignableFrom(type) => FieldKind.SubPacket,
            _ => FieldKind.Value,
        };
    }

    // A field that is on the line, or read a certain way, only for some values of an earlier field.
    internal sealed class FieldCondition
    {
        private readonly Func<object, object?> _read;
        private readonly object[] _values;

        public FieldCondition(Type packetType, string field, object[] values)
        {
            _values = values;
            if (packetType.GetProperty(field) is not { } property)
            {
                _read = static _ => null;
                return;
            }

            var packet = Expression.Parameter(typeof(object));
            _read = Expression.Lambda<Func<object, object?>>(
                Expression.Convert(Expression.Property(property.GetMethod?.IsStatic == true ? null : Expression.Convert(packet, packetType), property), typeof(object)),
                packet).Compile();
        }

        public bool Holds(object packet)
        {
            var value = _read(packet);
            foreach (var expected in _values)
            {
                if (Equals(expected, value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
