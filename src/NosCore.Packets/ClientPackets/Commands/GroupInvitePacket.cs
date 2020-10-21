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
    [PacketHeader("$Party", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("$Invitation", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("$Gruppeneinladung", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("$InvitoGruppo", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("$Invitaragrupo", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("$Party", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("$Пригласить-группа", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("$GrupDaveti", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("$Skupina", Flag = nameof(RegionType.CS))]
    public class GroupInvitePacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}