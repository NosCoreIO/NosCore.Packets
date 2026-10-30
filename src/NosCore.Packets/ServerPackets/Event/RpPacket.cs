//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Event
{
    // Marks (x, y) on the given map; clicking the mark sends `Packet` back, as the Amulet of
    // Return does with its u_i.
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
        public IPacket? Packet { get; set; }
    }
}
