using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("char_sc")]
    public class CharScPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte Size { get; set; }
    }
}