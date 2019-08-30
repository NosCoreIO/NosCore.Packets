using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Parcel
{
    [PacketHeader("pcl")]
    public class PclPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public int GiftId { get; set; }
    }
}
