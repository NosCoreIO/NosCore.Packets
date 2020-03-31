using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Mates
{
    [PacketHeader("pski")]
    public class PSkiPacket : PacketBase
    {
        [PacketIndex(0)]
        public long FirstSkill { get; set; }

        [PacketIndex(1)]
        public long SecondSkill { get; set; }

        [PacketIndex(2)]
        public long ThirdSkill { get; set; }
    }
}