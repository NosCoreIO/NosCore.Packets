using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("sit_sub_packet")]
    public class SitSubPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }
    }
}