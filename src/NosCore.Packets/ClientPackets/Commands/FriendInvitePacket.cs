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
    [PacketHeader("$Adding", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("$Ajouter", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("$Hinzufügen", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("$Aggiungi", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("$Añadir", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("$Dodaj", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("$Добавить", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("$Ekle", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("$Pøidat", Flag = nameof(RegionType.CS))]
    public class FriendInvitePacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}