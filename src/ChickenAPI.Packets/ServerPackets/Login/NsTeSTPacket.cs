using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Login
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