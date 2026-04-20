//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // Act4 raid timer banner ("dg" = "defend guild"-era holdover). RaidType selects
    // the event icon, Urgency is 1 (>30min) or 2 (<=30min) to flip the colour, Seconds
    // drives the countdown, last field stays 0 in stock OpenNos.
    [PacketHeader("dg", Scope.InGame)]
    public class DgPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte RaidType { get; set; }

        [PacketIndex(1)]
        public byte Urgency { get; set; }

        [PacketIndex(2)]
        public int Seconds { get; set; }

        [PacketIndex(3)]
        public int Unknown { get; set; }
    }
}
