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
    [PacketHeader("%Familydeputy", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Assistantdefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienvertreter", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Vicecapo", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Representante", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Reprezentant", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Представитель", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%Aile", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Zástupce", Flag = nameof(RegionType.CS))]
    public class FamilyDeputyPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}