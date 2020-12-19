//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("c_info", Scope.InGame)]
    public class CInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Name { get; set; }

        [PacketIndex(1)]
        public string? Unknown1 { get; set; } //TODO to find

        [PacketIndex(2)]
        public short? GroupId { get; set; }

        [PacketIndex(3)]
        public int FamilyId { get; set; }

        [PacketIndex(4)]
        public string? FamilyName { get; set; }

        [PacketIndex(5)]
        public long CharacterId { get; set; }

        [PacketIndex(6)]
        public AuthorityType Authority { get; set; }

        [PacketIndex(7)]
        public GenderType Gender { get; set; }

        [PacketIndex(8)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(9)]
        public HairColorType HairColor { get; set; }

        [PacketIndex(10)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(11)]
        public byte Icon { get; set; }

        [PacketIndex(12)]
        public short Compliment { get; set; }

        [PacketIndex(13)]
        public short Morph { get; set; }

        [PacketIndex(14)]
        public bool Invisible { get; set; }

        [PacketIndex(15)]
        public byte FamilyLevel { get; set; }

        [PacketIndex(16)]
        public byte MorphUpgrade { get; set; }

        [PacketIndex(17)]
        public bool ArenaWinner { get; set; }
    }
}