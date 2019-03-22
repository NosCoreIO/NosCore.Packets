using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("lev")]
    public class LevPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Level { get; set; }

        [PacketIndex(1)]
        public long LevelXp { get; set; }

        [PacketIndex(2)]
        public byte JobLevel { get; set; }

        [PacketIndex(3)]
        public long JobLevelXp { get; set; }

        [PacketIndex(4)]
        public long XpLoad { get; set; }

        [PacketIndex(5)]
        public long JobXpLoad { get; set; }

        [PacketIndex(6)]
        public long Reputation { get; set; }

        [PacketIndex(7)]
        public int SkillCp { get; set; }

        [PacketIndex(8)]
        public long HeroXp { get; set; }

        [PacketIndex(9)]
        public byte HeroLevel { get; set; }

        [PacketIndex(10)]
        public long HeroXpLoad { get; set; }
    }
}