using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Shops
{
    [PacketHeader("sell_list")]
    public class SellListPacket : PacketBase
    {
        [PacketIndex(0)]
        public long ValueSold { get; set; }

        [PacketIndex(1)]
        public List<SellListSubPacket> SellListSubPacket { get; set; }
    }
}