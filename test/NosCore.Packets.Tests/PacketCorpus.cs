//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace NosCore.Packets.Tests
{
    // Builds every [PacketHeader] packet in the assembly, filled with values derived
    // from a counter rather than a random source so the same corpus is produced on
    // every run and on every machine.
    //
    // This exists so the generated serializer can be diffed against the expression-tree
    // one across the whole packet surface instead of the handful of packets
    // SerializationTests covers by hand.
    public static class PacketCorpus
    {
        public static IReadOnlyList<Type> PacketTypes { get; } =
            typeof(IPacket).Assembly.GetTypes()
                .Where(t => t is { IsClass: true, IsAbstract: false } && typeof(PacketBase).IsAssignableFrom(t))
                .Where(t => t.GetCustomAttribute<PacketHeaderAttribute>() != null)
                .OrderBy(t => t.FullName, StringComparer.Ordinal)
                .ToList();

        // Every type the Serializer/Deserializer must know about: the headered packets
        // plus the sub-packet types they nest, which carry PacketIndex properties but
        // often no header of their own.
        public static IReadOnlyList<Type> SerializableTypes { get; } =
            typeof(IPacket).Assembly.GetTypes()
                .Where(t => t is { IsClass: true, IsAbstract: false } && typeof(PacketBase).IsAssignableFrom(t))
                .OrderBy(t => t.FullName, StringComparer.Ordinal)
                .ToList();

        public static IPacket Build(Type packetType, int seed)
        {
            var counter = new Counter(seed);
            return (IPacket)Populate(packetType, counter, depth: 0);
        }

        private static object Populate(Type type, Counter counter, int depth)
        {
            var instance = Construct(type);

            foreach (var property in type.GetProperties()
                .Where(p => p.CanWrite && p.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                .OrderBy(p => p.GetCustomAttributes(true).OfType<PacketIndexAttribute>().First().Index))
            {
                var value = ValueFor(property.PropertyType, counter, depth);
                if (value == null)
                {
                    continue;
                }

                try
                {
                    property.SetValue(instance, value);
                }
                catch (TargetInvocationException)
                {
                    // Some indexed properties are projections whose setter validates
                    // (TwkPacket.ClientLanguageString parses into RegionType). Those keep
                    // their default rather than being forced to a value the type rejects.
                }
            }

            return instance;
        }

        // Several packets are records with positional parameters and no parameterless
        // constructor. Deserializer builds those the same way: smallest constructor,
        // default for every argument, then the indexed properties are assigned.
        private static object Construct(Type type)
        {
            var ctor = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public)
                .OrderBy(c => c.GetParameters().Length)
                .First();

            var args = ctor.GetParameters()
                .Select(p => p.ParameterType.IsValueType && Nullable.GetUnderlyingType(p.ParameterType) == null
                    ? Activator.CreateInstance(p.ParameterType)
                    : null)
                .ToArray();

            return ctor.Invoke(args);
        }

        private static object? ValueFor(Type type, Counter counter, int depth)
        {
            var underlying = Nullable.GetUnderlyingType(type) ?? type;

            if (underlying == typeof(string))
            {
                // No spaces or '^': those are wire separators, and a value containing one
                // would make a serializer difference indistinguishable from a data quirk.
                return $"s{counter.Next()}";
            }

            if (underlying.IsEnum)
            {
                var values = Enum.GetValues(underlying);
                return values.Length == 0 ? null : values.GetValue(counter.Next() % values.Length);
            }

            if (underlying == typeof(bool))
            {
                return counter.Next() % 2 == 0;
            }

            if (underlying == typeof(char))
            {
                return (char)('a' + (counter.Next() % 26));
            }

            if (underlying.IsPrimitive || underlying == typeof(decimal))
            {
                return NumericValue(underlying, counter);
            }

            if (underlying == typeof(DateTime))
            {
                return new DateTime(2020, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(counter.Next());
            }

            // A property declared as IPacket is the injection point the serializer fills
            // in reflectively; give it a concrete headered packet to inject.
            if (underlying == typeof(IPacket))
            {
                return depth > 2 ? null : Populate(InjectionPacketType, counter, depth + 1);
            }

            if (typeof(IPacket).IsAssignableFrom(underlying))
            {
                return depth > 2 ? null : Populate(underlying, counter, depth + 1);
            }

            if (typeof(IEnumerable).IsAssignableFrom(underlying) && underlying != typeof(string))
            {
                return ListValue(underlying, counter, depth);
            }

            return null;
        }

        private static object? ListValue(Type listType, Counter counter, int depth)
        {
            var elementType = listType.IsArray
                ? listType.GetElementType()!
                : listType.GenericTypeArguments.FirstOrDefault();

            if (elementType == null || depth > 2)
            {
                return null;
            }

            var items = Enumerable.Range(0, 2)
                .Select(_ => ValueFor(elementType, counter, depth + 1))
                .Where(v => v != null)
                .ToList();

            var typedList = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(elementType))!;
            foreach (var item in items)
            {
                typedList.Add(item);
            }

            if (listType.IsArray)
            {
                var array = Array.CreateInstance(elementType, typedList.Count);
                typedList.CopyTo(array, 0);
                return array;
            }

            return listType.IsAssignableFrom(typedList.GetType()) ? typedList : null;
        }

        private static object NumericValue(Type type, Counter counter)
        {
            // Kept small and positive so every width can hold it; the serializer formats
            // via ToString(), so magnitude is not what is under test here.
            var raw = counter.Next() % 100;
            return Convert.ChangeType(raw, type, CultureInfo.InvariantCulture);
        }

        private static readonly Type InjectionPacketType =
            typeof(IPacket).Assembly.GetTypes()
                .Where(t => t is { IsClass: true, IsAbstract: false } && typeof(PacketBase).IsAssignableFrom(t))
                .Where(t => t.GetCustomAttribute<PacketHeaderAttribute>() != null)
                // Only the indexed properties matter here - every packet inherits
                // PacketBase.ValidationResult, which is a List<> and would otherwise
                // disqualify the entire assembly.
                .Where(t => t.GetProperties()
                    .Where(p => p.GetCustomAttributes(true).OfType<PacketIndexAttribute>().Any())
                    .All(p =>
                        !typeof(IPacket).IsAssignableFrom(p.PropertyType) &&
                        !(typeof(IEnumerable).IsAssignableFrom(p.PropertyType) && p.PropertyType != typeof(string))))
                .OrderBy(t => t.FullName, StringComparer.Ordinal)
                .First();

        // Plain LCG rather than System.Random: the corpus has to be byte-identical
        // across runtimes, and Random's algorithm is not contractually stable.
        private sealed class Counter(int seed)
        {
            private uint _state = (uint)seed + 1u;

            public int Next()
            {
                _state = (_state * 1664525u) + 1013904223u;
                return (int)(_state >> 16 & 0x7FFF);
            }
        }
    }
}
