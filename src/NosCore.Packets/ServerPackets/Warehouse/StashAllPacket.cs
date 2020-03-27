using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Warehouse
{
    [PacketHeader("stash_all")]
    public class StashAllPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte WarehouseSize { get; set; }

        [PacketIndex(1)]
        public List<IvnSubPacket>? IvnSubPackets { get; set; }
    }
}