using System.Collections.Generic;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
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