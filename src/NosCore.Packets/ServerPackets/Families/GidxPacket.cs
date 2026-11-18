//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    [PacketHeader("gidx", Scope.InGame | Scope.InTrade)]
    public class GidxPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long? FamilyId { get; set; }

        [PacketIndex(3, SpecialSeparator = ".", IsOptional = true)]
        public Game18NConstString? FamilyRank { get; set; }

        [PacketIndex(4)]
        public string? FamilyName { get; set; }

        [PacketIndex(5)]
        public byte FamilyLevel { get; set; }

        // The family tag shows at most one icon: the third value 2, else the third 1, else the second 1,
        // else the first 1 picks it.
        [PacketListIndex(6, ListSeparator = "|")]
        public List<byte> FamilyIcons { get; set; } = new();
    }
}
