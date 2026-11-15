//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.RainbowBattle
{
    [PacketHeader("fblst_sub_packet", Scope.InGame)]
    public class FblstSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Level { get; set; }

        // The specialist card morph the member wears, -1 without one.
        [PacketIndex(1)]
        public int Morph { get; set; }

        [PacketIndex(2)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(3)]
        public int Kills { get; set; }

        [PacketIndex(4)]
        public string? Name { get; set; }

        [PacketIndex(5)]
        public GenderType Gender { get; set; }

        [PacketIndex(6)]
        public long CharacterId { get; set; }

        [PacketIndex(7)]
        public byte HeroLevel { get; set; }
    }
}
