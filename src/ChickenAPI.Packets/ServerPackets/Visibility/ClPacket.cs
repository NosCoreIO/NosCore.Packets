using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Visibility
{
    [PacketHeader("cl")]
    public class ClPacket : PacketBase
    {
        [PacketIndex(0)]
        public long VisualId { get; set; }

        [PacketIndex(1)]
        public bool Camouflage { get; set; }

        [PacketIndex(2)]
        public bool Invisible { get; set; }
    }
}