using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Shops
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