using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("sell_list")]
    public class SellListPacket : IPacket
    {
        [PacketIndex(0)]
        public long ValueSold { get; set; }

        [PacketIndex(1)]
        public List<SellListSubPacket> SellListSubPacket { get; set; }
    }
}