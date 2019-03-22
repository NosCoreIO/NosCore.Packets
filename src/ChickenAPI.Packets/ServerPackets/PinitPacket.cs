using System.Collections.Generic;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
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