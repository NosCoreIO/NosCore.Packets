//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.TimeSpaces
{
    public class MinfoObjectiveSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Vnum { get; set; }

        [PacketIndex(1)]
        public int Current { get; set; }

        [PacketIndex(2, SpecialSeparator = "/")]
        public int Total { get; set; }
    }
}
