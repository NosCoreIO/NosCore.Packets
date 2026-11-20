//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.Benchmark
{
    // The serializer and the two readers a server and a client build: each side reads the other side's packets.
    public static class Engines
    {
        private static readonly List<Type> PacketTypes = typeof(PacketBase).Assembly.GetTypes()
            .Where(type => type is { IsClass: true, IsAbstract: false } && typeof(PacketBase).IsAssignableFrom(type))
            .OrderBy(type => type.FullName, StringComparer.Ordinal)
            .ToList();

        private static readonly HashSet<string> ServerHeaders = PacketTypes.Where(IsServerPacket)
            .Select(type => type.GetCustomAttribute<PacketHeaderAttribute>()?.Identification)
            .OfType<string>()
            .ToHashSet();

        public static Serializer Serializer { get; } = new(PacketTypes);

        public static Deserializer ServerSide { get; } = new(PacketTypes.Where(type => !IsServerPacket(type)));

        public static Deserializer ClientSide { get; } = new(PacketTypes.Where(type => IsServerPacket(type)
            || !ServerHeaders.Contains(type.GetCustomAttribute<PacketHeaderAttribute>()?.Identification ?? string.Empty)));

        private static bool IsServerPacket(Type type) => type.Namespace?.Contains(".ServerPackets", StringComparison.Ordinal) == true;
    }
}
