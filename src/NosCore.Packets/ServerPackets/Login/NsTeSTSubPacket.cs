//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("NsTeST_sub_packet", Scope.OnLoginScreen)]
    public class NsTeStSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Host { get; set; }

        [PacketIndex(1, SpecialSeparator = ":")]
        public ushort? Port { get; set; }

        [PacketIndex(2, SpecialSeparator = ":")]
        public int? Color { get; set; }

        [PacketIndex(3, SpecialSeparator = ":")]
        public int WorldCount { get; set; }

        [PacketIndex(4)]
        public int WorldId { get; set; }

        [PacketIndex(5)]
        public string? Name { get; set; }
    }
}