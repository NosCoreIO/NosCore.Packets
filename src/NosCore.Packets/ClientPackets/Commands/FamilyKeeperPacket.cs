//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Commands
{
    [PacketHeader("%Familykeeper")]
    [PacketHeaderAlias("%Gardiendefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienverwalter", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Guardiano", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Nombrar", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familykeeper", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Управляющий-назначить", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%AileBabasý", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Správce", Flag = nameof(RegionType.CS))]
    public class FamilyKeeperPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}