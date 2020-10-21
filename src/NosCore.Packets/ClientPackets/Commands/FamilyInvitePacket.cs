//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Commands
{
    [PacketHeader("%Familyinvite", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Invitationdefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familieneinladung", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Invita", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Invitación", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familyinvite", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Пригласить-семья", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%Aileden", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Rodina", Flag = nameof(RegionType.CS))]
    public class FamilyInvitePacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}