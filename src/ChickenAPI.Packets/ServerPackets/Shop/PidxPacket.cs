using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Shop
{
    [PacketHeader("pidx")]
    public class PidxPacket : PacketBase
    {
        [PacketIndex(0)]
        public long GroupId { get; set; }

        [PacketIndex(1)]
        public List<PidxSubPacket> SubPackets { get; set; }
    }
}