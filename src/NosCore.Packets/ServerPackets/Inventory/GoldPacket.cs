//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Inventory
{
    [PacketHeader("gold")]
    public class GoldPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public long Gold { get; set; }

        [PacketIndex(1)]
        public int Unknown { get; set; }
    }
}