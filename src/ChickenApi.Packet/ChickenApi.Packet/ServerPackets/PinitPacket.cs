using System.Collections.Generic;

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