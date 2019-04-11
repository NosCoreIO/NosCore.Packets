using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Shops
{
    public class SellListSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public long Amount { get; set; }

        [PacketIndex(2)]
        public long SellAmount { get; set; }
    }
}