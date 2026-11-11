//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Commands
{
    [PacketHeader("%Title", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Titre", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Titel", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Titolo", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Título", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Tytuł", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Unvan", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Titul", Flag = nameof(RegionType.CS))]
    public class FamilyTitlePacket : PacketBase
    {
        [PacketIndex(0)]
        public required string CharacterName { get; set; }

        [PacketIndex(1)]
        public FamilyMemberRank Rank { get; set; }
    }
}
