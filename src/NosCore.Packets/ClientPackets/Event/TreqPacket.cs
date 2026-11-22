//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Event
{
    [PacketHeader("treq", Scope.InGame)]
    public class TreqPacket : PacketBase
    {
        [PacketIndex(0)]
        public int X { get; set; }

        [PacketIndex(1)]
        public int Y { get; set; }

        [PacketIndex(2)]
        public bool? StartPress { get; set; }

        [PacketIndex(3)]
        public bool? RecordPress { get; set; }

        // Set when the player accepted the gold a record challenge costs.
        [PacketIndex(4, IsOptional = true)]
        public bool? GoldAccepted { get; set; }
    }
}