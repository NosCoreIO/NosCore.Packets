using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Relations
{
    [PacketHeader("blinit")]
    public class BlinitPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = "|")]
        public List<BlinitSubPacket> SubPackets { get; set; }
    }
}