using System.Collections.Generic;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("blinit")]
    public class BlinitPacket : IPacket
    {
        [PacketIndex(0, SpecialSeparator = "|")]
        public List<BlinitSubPacket> SubPackets { get; set; }
    }
}