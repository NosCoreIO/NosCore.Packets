using System.Collections.Generic;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("finit")]
    public class FinitPacket : IPacket
    {
        [PacketIndex(0, SpecialSeparator = "|")]
        public List<FinitSubPacket> SubPackets { get; set; }
    }
}