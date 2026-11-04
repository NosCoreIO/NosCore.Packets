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
    [PacketHeader("%Gender", Scope.InGame | Scope.InTrade)]
    [PacketHeaderAlias("%Sexe", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Geschlecht", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Sesso", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Sexo", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Płeć", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Cinsiyet", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Pohlaví", Flag = nameof(RegionType.CS))]
    public class FamilyGenderPacket : PacketBase
    {
        [PacketIndex(0)]
        public GenderType Gender { get; set; }
    }
}
