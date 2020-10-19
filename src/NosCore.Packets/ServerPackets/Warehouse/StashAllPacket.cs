//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Warehouse
{
    [PacketHeader("stash_all")]
    public class StashAllPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public byte WarehouseSize { get; set; }

        [PacketListIndex(1)]
        public List<IvnSubPacket>? IvnSubPackets { get; set; }
    }
}