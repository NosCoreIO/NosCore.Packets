using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
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