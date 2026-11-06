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

        // -1 whenever there is a family; without it the client prints a message after the
        // player's own family tag.
        [PacketIndex(3, SpecialSeparator = ".", IsOptional = true)]
        public short? Unknown { get; set; }

        [PacketIndex(4)]
        public string? FamilyName { get; set; }

        [PacketIndex(5)]
        public byte FamilyLevel { get; set; }

        [PacketListIndex(6, ListSeparator = "|")]
        public List<bool> FamilyIcons { get; set; } = new();
    }
}
