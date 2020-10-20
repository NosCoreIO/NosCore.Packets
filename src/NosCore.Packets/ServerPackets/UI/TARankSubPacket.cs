//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    public class TARankSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short? Score { get; set; }

        [PacketIndex(1)]
        public byte? Level { get; set; }

        [PacketIndex(2)]
        public byte? HeroLevel { get; set; }

        [PacketIndex(3)]
        public string? Name { get; set; }

        [PacketIndex(4)]
        public CharacterClassType? CharacterClass { get; set; }

        [PacketIndex(5)]
        public GenderType? Gender { get; set; }

        [PacketIndex(6)]
        public short? Morph { get; set; }
    }
}