//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    // The Act 4 faction HUD: the receiver's faction, then the angel side's war state and the
    // demon side's.
    [PacketHeader("fc", Scope.InGame)]
    public class FcPacket : PacketBase
    {
        [PacketIndex(0)]
        public FactionType Faction { get; set; }

        [PacketIndex(1)]
        public int MinutesUntilReset { get; set; }

        [PacketIndex(2, SpecialSeparator = " ")]
        public FcSubPacket? Angel { get; set; }

        [PacketIndex(3, SpecialSeparator = " ")]
        public FcSubPacket? Demon { get; set; }
    }
}
