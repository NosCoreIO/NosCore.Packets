//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // One effect of an item's runes, written as a card effect ("105.4.4.7680.1").
    public class EInfoRuneSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte SubType { get; set; }

        [PacketIndex(2)]
        public int FirstData { get; set; }

        [PacketIndex(3)]
        public int SecondData { get; set; }

        // From -6 to 6.
        [PacketIndex(4)]
        public short Unknown { get; set; }
    }
}
