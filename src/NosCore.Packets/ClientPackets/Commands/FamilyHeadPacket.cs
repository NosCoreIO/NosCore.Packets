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
    [PacketHeader("%Familyhead", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Têtedefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienoberhaupt", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Capofamiglia", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Familyhead", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Szef", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Глава", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%Ailereisi", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Familyhead", Flag = nameof(RegionType.CS))]
    public class FamilyHeadPacket : PacketBase
    {
        [PacketIndex(0)]
        public required string CharacterName { get; set; }
    }
}