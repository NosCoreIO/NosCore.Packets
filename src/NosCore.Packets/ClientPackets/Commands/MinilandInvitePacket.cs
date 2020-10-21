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
    [PacketHeader("$Invite", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("$Inviter", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("$Einladung", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("$Invita", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("$Invitación", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("$Invite", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("$Пригласить", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("$Davet", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("$Pozvi", Flag = nameof(RegionType.CS))]
    public class MinilandInvitePacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}