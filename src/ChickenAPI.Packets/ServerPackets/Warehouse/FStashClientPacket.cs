using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.ServerPackets.Inventory;

namespace ChickenAPI.Packets.ServerPackets.Warehouse
{
    [PacketHeader("f_stash")]
    public class FStashClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public List<IvnSubPacket> IvnSubPackets { get; set; }
    }
}