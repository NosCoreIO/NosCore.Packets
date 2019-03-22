using System.Collections.Generic;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("NsTeST")]
    public class NsTestPacket : IPacket
    {
        [PacketIndex(0)]
        public string AccountName { get; set; }

        [PacketIndex(1)]
        public int SessionId { get; set; }

        [PacketIndex(2)]
        public List<NsTeStSubPacket> SubPacket { get; set; }
    }
}