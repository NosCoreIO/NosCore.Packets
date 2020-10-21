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
    [PacketHeader("$Partylocation", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("$RalliementGroupe", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("$Gruppenstandort", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("$Posizione", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("$Posición", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("$Partylocation", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("$Место-группы", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("$Grup", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("$Pozice", Flag = nameof(RegionType.CS))]
    public class PartyLocationPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}