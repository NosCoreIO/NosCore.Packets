//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // Act 4 raid countdown: Urgency 1 above 30 minutes left, 2 below, which flips the colour.
    [PacketHeader("dg", Scope.InGame)]
    public class DgPacket : PacketBase
    {
        [PacketIndex(0)]
        public Act4RaidType RaidType { get; set; }

        [PacketIndex(1)]
        public byte Urgency { get; set; }

        [PacketIndex(2)]
        public int Seconds { get; set; }

        [PacketIndex(3)]
        public int Unknown { get; set; }
    }
}
