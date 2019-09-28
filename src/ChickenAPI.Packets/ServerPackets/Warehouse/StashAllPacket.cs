using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.ServerPackets.Inventory;

namespace ChickenAPI.Packets.ServerPackets.Warehouse
{
    [PacketHeader("stash_all")]
    public class StashAllPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte WarehouseSize { get; set; }

        [PacketIndex(1)]
        public List<IvnSubPacket> IvnSubPackets { get; set; }
    }
}