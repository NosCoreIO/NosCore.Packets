using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    public class StpSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public int SkillId { get; set; }

        [PacketIndex(1)]
        public byte Rank1 { get; set; }

        [PacketIndex(2)]
        public byte Rank2 { get; set; }

        [PacketIndex(3)]
        public short Unknown { get; set; } //TODO to find
    }
}
