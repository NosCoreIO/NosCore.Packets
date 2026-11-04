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
    [PacketHeader("%Notice", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Avertissement", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Hinweis", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Nota", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Aviso", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Notice", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Not", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Notice", Flag = nameof(RegionType.CS))]
    public class FamilyNoticePacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}
