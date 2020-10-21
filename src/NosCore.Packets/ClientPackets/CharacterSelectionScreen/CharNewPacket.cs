//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.CharacterSelectionScreen
{
    [PacketHeader("Char_NEW", Scope.OnCharacterScreen)]
    public class CharNewPacket : PacketBase
    {
        [PacketIndex(0)]
        [StringLength(15, MinimumLength = 3)]
        public string? Name { get; set; }

        [PacketIndex(1)]
        [Range(0, 3)]
        public byte Slot { get; set; }

        [PacketIndex(2)]
        public GenderType Gender { get; set; }

        [PacketIndex(3)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(4)]
        public HairColorType HairColor { get; set; }

        public bool IsMartialArtist { get; set; }
    }
}