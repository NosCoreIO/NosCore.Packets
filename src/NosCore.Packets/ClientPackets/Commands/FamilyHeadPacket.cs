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
    [PacketHeader("%Familyhead", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Tetedefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienoberhaupt", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%capo", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Patriarca", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familyhead", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Глава", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%AileReisi", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Hlava", Flag = nameof(RegionType.CS))]
    public class FamilyHeadPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}