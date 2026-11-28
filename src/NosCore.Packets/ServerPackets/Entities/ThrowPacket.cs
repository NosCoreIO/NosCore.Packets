//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Entities
{
    // An item flying from one cell to the one it lands on, such as a raid boss's loot. It puts the item on the
    // ground in place of a drop packet; for gold the amount is the gold in the pile.
    [PacketHeader("throw", Scope.InGame)]
    public class ThrowPacket : PacketBase
    {
        [PacketIndex(0)]
        public short VNum { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short FromX { get; set; }

        [PacketIndex(3)]
        public short FromY { get; set; }

        [PacketIndex(4)]
        public short ToX { get; set; }

        [PacketIndex(5)]
        public short ToY { get; set; }

        [PacketIndex(6)]
        public int Amount { get; set; }
    }
}
