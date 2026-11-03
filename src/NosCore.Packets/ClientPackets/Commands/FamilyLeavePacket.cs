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
    [PacketHeader("%Familyleave", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Congédefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienaustritt", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Esci", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Familyleave", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familyleave", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Покинуть", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%Ailedençıkış", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Familyleave", Flag = nameof(RegionType.CS))]
    public class FamilyLeavePacket : PacketBase
    {
    }
}