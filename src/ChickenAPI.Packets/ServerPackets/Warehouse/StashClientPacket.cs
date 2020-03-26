using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.ServerPackets.Inventory;

namespace ChickenAPI.Packets.ServerPackets.Warehouse
{
    [PacketHeader("stash")]
    public class StashClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public List<IvnSubPacket?>? IvnSubPackets { get; set; }
    }
}