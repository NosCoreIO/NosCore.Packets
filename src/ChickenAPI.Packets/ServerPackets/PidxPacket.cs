using System.Collections.Generic;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("pidx")]
    public class PidxPacket : IPacket
    {
        [PacketIndex(0)]
        public long GroupId { get; set; }

        [PacketIndex(1)]
        public List<PidxSubPacket> SubPackets { get; set; }
    }
}