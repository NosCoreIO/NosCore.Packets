﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Commands
{
    [PacketHeader("%Familydismiss")]
    [PacketHeaderAlias("%Rejetdefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familienentlassung", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Allontana", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Expulsión", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familydismiss", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Выгнать", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%AiledenÇýkma", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Vyhození", Flag = nameof(RegionType.CS))]
    public class FamilyDismissPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}