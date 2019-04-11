using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("cond")]
    public class CondPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public bool NoAttack { get; set; }

        [PacketIndex(3)]
        public bool NoMove { get; set; }

        [PacketIndex(4)]
        public byte Speed { get; set; }
    }
}