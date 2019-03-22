using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("dir")]
    public class DirPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte Direction { get; set; }
    }
}