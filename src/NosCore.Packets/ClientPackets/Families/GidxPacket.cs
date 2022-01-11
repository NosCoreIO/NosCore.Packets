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

namespace NosCore.Packets.ClientPackets.Families
{
    [PacketHeader("gidx", Scope.InGame | Scope.InTrade)]
    public class GidxPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long FamilyId { get; set; }

        [PacketIndex(3)]
        public string? FamilyName { get; set; }

        [PacketIndex(4)]
        public string? FamilyCustomRank { get; set; }

        [PacketIndex(5)]
        public byte FamilyLevel { get; set; }

        [PacketListIndex(6, ListSeparator = "|")]
        public List<bool> FamilyIcons { get; set; } = new ();
    }
}