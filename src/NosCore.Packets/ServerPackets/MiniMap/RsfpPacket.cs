//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.MiniMap
{
    [PacketHeader("rsfp")]
    public class RsfpPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public long MapX { get; set; }

        [PacketIndex(1)]
        public long MapY { get; set; }
    }
}