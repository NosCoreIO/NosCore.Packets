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
    [PacketHeader("%Familyshout", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Cridefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienruf", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Grido", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Familyshout", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familyshout", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Объявление", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%Aileçağrısı", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Familyshout", Flag = nameof(RegionType.CS))]
    public class FamilyShoutPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}