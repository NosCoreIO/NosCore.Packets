using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Inventory
{
    [PacketHeader("pdti")]
    public class PdtiPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Unknow { get; set; } // TODO find this - type 10 and 11

        [PacketIndex(1)]
        public long ItemVnum { get; set; }

        [PacketIndex(2)]
        public short RecipeAmount { get; set; } // TODO review this - type 1 and Recipe Amount

        [PacketIndex(3)]
        public short Unknow3 { get; set; } // TODO find this - type 26 and 27

        [PacketIndex(4)]
        public short ItemUpgrade { get; set; }

        [PacketIndex(5)]
        public short Unknow4 { get; set; } // TODO find this - always 0
    }
}