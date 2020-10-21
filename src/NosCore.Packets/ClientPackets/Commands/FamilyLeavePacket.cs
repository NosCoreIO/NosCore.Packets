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
    [PacketHeader("%Familyleave", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Congédefamill", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienaustritt", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Uscita", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Salida", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familyleave", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Покинуть", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%AileÇaðrýsý", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Opustit", Flag = nameof(RegionType.CS))]
    public class FamilyLeavePacket : PacketBase
    {
    }
}