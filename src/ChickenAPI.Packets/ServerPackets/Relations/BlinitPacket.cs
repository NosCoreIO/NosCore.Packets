using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Relations
{
    [PacketHeader("blinit")]
    public class BlinitPacket : IPacket
    {
        [PacketIndex(0, SpecialSeparator = "|")]
        public List<BlinitSubPacket> SubPackets { get; set; }
    }
}