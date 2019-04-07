using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Groups
{
    [PacketHeader("pinit")]
    public class PinitPacket : IPacket
    {
        [PacketIndex(0)]
        public int GroupSize { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public List<PinitSubPacket> PinitSubPackets { get; set; }
    }
}