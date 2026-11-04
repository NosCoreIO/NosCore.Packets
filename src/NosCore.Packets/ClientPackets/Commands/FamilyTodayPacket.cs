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
    [PacketHeader("%Today", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Aujourd'hui", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Heute", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Oggi", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Hoy", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Today", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Bugün", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Today", Flag = nameof(RegionType.CS))]
    public class FamilyTodayPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}
