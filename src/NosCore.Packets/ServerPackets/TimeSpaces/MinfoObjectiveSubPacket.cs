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
        // The client reads an objective the mission does not have as "-1.0/0"; a bare "-1" hangs it.
        public static MinfoObjectiveSubPacket None => new() { Vnum = -1 };

        [PacketIndex(0)]
        public int Vnum { get; set; }

        [PacketIndex(1)]
        public int Current { get; set; }

        [PacketIndex(2, SpecialSeparator = "/")]
        public int Total { get; set; }
    }
}
