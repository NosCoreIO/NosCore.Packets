using System.Collections.Generic;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("rest")]
    public class SitPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Amount { get; set; }

        [PacketIndex(1, Length = -1)]
        public List<SitSubPacket> Users { get; set; }
    }
}