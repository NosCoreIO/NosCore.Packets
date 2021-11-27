//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Visibility
{
    public class InNonPlayerSubPacket : PacketBase
    {
        [PacketIndex(1)]
        public InAliveSubPacket? InAliveSubPacket { get; set; }

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
        public string? Name { get; set; }

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
        public bool IsInvisible { get; set; }

        [PacketIndex(20)]
        public Game18NConstString Title { get; set; }

        [PacketIndex(21)]
        public byte Unknow5 { get; set; }

        [PacketIndex(22)]
        public byte Unknow6 { get; set; }
    }
}