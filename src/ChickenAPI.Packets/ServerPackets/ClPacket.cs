using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("cl")]
    public class ClPacket : IPacket
    {
        [PacketIndex(0)]
        public long VisualId { get; set; }

        [PacketIndex(1)]
        public bool Camouflage { get; set; }

        [PacketIndex(2)]
        public bool Invisible { get; set; }
    }
}