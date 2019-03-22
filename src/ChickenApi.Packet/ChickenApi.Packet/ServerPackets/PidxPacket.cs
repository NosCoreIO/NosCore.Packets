using System.Collections.Generic;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("pidx")]
    public class PidxPacket : IPacket
    {
        [PacketIndex(0)]
        public long GroupId { get; set; }

        [PacketIndex(1)]
        public List<PidxSubPacket> SubPackets { get; set; }
    }
}