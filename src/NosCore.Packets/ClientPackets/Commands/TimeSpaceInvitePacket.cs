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
    [PacketHeader("$Accompany", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("$Accompagner", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("$Begleiten", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("$Accompagna", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("$Acompañar", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("$Accompany", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("$Сопровождать", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("$Eþlik", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("$Doprovázet", Flag = nameof(RegionType.CS))]
    public class TimeSpaceInvitePacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}