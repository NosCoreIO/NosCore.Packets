//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("n_inv", Scope.InGame)]
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

        [PacketListIndex(4, IsOptional = true)]
        public List<NInvItemSubPacket?>? Items { get; set; }

        [PacketListIndex(5, IsOptional = true)]
        public List<short>? Skills { get; set; }

        [PacketListIndex(6, IsOptional = true, SpecialSeparator = "|")]
        public List<NInvFamilySkillSubPacket?>? FamilySkills { get; set; }
    }
}