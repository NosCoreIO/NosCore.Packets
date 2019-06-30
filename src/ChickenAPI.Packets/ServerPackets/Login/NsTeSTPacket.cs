using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Login
{
    [PacketHeader("NsTeST")]
    public class NsTestPacket : PacketBase
    {
        [PacketIndex(0)]
        public string AccountName { get; set; }

        [PacketIndex(1)]
        public int SessionId { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public int? Unknown { get; set; }

        [PacketIndex(3)]
        public List<NsTeStSubPacket> SubPacket { get; set; }
    }
}