using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    public class SellListSubPacket : IPacket
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public long Amount { get; set; }

        [PacketIndex(2)]
        public long SellAmount { get; set; }
    }
}