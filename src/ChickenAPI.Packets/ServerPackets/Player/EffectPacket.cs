using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("eff")]
    public class EffectPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType EffectType { get; set; }

        [PacketIndex(1)]
        public long VisualEntityId { get; set; }

        [PacketIndex(2)]
        public int Id { get; set; }
    }
}