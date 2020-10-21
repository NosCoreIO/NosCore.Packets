//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    public class MloInfoPacketSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long MinimumPoints { get; set; }

        [PacketIndex(1)]
        public long MaximumPoints { get; set; }
    }
}
