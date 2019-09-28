using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Warehouse
{
    [PacketHeader("repos")]
    public class ReposPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte OldSlot { get; set; }

        [PacketIndex(1)]
        public short Amount { get; set; }

        [PacketIndex(2)]
        public byte NewSlot { get; set; }

        [PacketIndex(3)]
        public bool PartnerBackpack { get; set; }
    }
}