//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    public class GmbrSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public long FamilyId { get; set; }

        [PacketIndex(2, SpecialSeparator = "|")]
        public string? Name { get; set; }

        [PacketIndex(3, SpecialSeparator = "|")]
        public byte Level { get; set; }

        [PacketIndex(4, SpecialSeparator = "|")]
        public CharacterClassType Class { get; set; }

        [PacketIndex(5, SpecialSeparator = "|")]
        public FamilyAuthority Authority { get; set; }

        [PacketIndex(6, SpecialSeparator = "|")]
        public FamilyMemberRank Rank { get; set; }

        [PacketIndex(7, SpecialSeparator = "|")]
        public bool IsConnected { get; set; }

        [PacketIndex(8, SpecialSeparator = "|")]
        public byte HeroLevel { get; set; }
    }
}
