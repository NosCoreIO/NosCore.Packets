//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // Raid portal placement. Tells the client to draw an orb at (x, y) on the given
    // map that — when clicked — triggers `param` (usually a #raid/#... command string
    // that the client echoes back as a UseObject).
    [PacketHeader("rp", Scope.InGame)]
    public class RpPacket : PacketBase
    {
        [PacketIndex(0)]
        public int MapId { get; set; }

        [PacketIndex(1)]
        public int X { get; set; }

        [PacketIndex(2)]
        public int Y { get; set; }

        [PacketIndex(3)]
        public string? Param { get; set; }
    }
}
