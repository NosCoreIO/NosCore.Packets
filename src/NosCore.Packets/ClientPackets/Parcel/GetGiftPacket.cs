using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Parcel
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
