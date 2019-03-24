using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("finit")]
    public class FinitPacket : IPacket
    {
        [PacketIndex(0, SpecialSeparator = "|")]
        public List<FinitSubPacket> SubPackets { get; set; }
    }
}