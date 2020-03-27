using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("n_inv")]
    public class NInvPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte Unknown { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public byte? ShopKind { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public List<NInvItemSubPacket?>? Items { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public List<short>? Skills { get; set; }

        [PacketIndex(6, IsOptional = true, SpecialSeparator = "|")]
        public List<NInvFamilySkillSubPacket?>? FamilySkills { get; set; }
    }
}