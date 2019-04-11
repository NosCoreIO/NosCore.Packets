using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Relations
{
    [PacketHeader("finit")]
    public class FinitPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = "|")]
        public List<FinitSubPacket> SubPackets { get; set; }
    }
}