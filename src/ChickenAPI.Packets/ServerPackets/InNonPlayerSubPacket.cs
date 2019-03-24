using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    public class InNonPlayerSubPacket : IPacket
    {
        [PacketIndex(1)]
        public InAliveSubPacket InAliveSubPacket { get; set; }

        [PacketIndex(2)]
        public short Dialog { get; set; }

        [PacketIndex(3)]
        public byte Faction { get; set; }

        [PacketIndex(4)]
        
        public short GroupEffect { get; set; }

        [PacketIndex(5)]
        public long? Owner { get; set; }

        [PacketIndex(6)]
        public SpawnEffectType SpawnEffect { get; set; }

        [PacketIndex(7)]
        public bool IsSitting { get; set; }

        [PacketIndex(8)]
        public short? Morph { get; set; }

        [PacketIndex(9)]
        public string Name { get; set; }

        [PacketIndex(10)]
        public byte Unknow1 { get; set; }

        [PacketIndex(11)]
        public short? Unknow2 { get; set; }

        [PacketIndex(12)]
        public byte Unknow3 { get; set; }

        [PacketIndex(13)]
        public short Skill1 { get; set; }

        [PacketIndex(14)]
        public short Skill2 { get; set; }

        [PacketIndex(15)]
        public short Skill3 { get; set; }

        [PacketIndex(16)]
        public short SkillRank1 { get; set; }

        [PacketIndex(17)]
        public short SkillRank2 { get; set; }

        [PacketIndex(18)]
        public short SkillRank3 { get; set; }

        [PacketIndex(19)]
        public byte Unknow4 { get; set; }
    }
}