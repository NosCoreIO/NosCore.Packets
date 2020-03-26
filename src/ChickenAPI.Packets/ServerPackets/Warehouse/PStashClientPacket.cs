using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.ServerPackets.Inventory;

namespace ChickenAPI.Packets.ServerPackets.Warehouse
{
    [PacketHeader("p_stash")]
    public class PStashClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public List<IvnSubPacket?>? IvnSubPackets { get; set; }
    }
}