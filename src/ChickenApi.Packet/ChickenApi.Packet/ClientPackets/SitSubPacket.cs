using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    public class SitSubPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }
    }
}