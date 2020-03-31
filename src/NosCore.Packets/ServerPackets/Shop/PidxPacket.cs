using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("pidx")]
    public class PidxPacket : PacketBase
    {
        [PacketIndex(0)]
        public long GroupId { get; set; }

        [PacketIndex(1)]
        public List<PidxSubPacket?>? SubPackets { get; set; }
    }
}