using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("eff")]
    public class EffectPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType EffectType { get; set; }

        [PacketIndex(1)]
        public long VisualEntityId { get; set; }

        [PacketIndex(2)]
        public int Id { get; set; }
    }
}