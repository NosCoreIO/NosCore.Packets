using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Relations
{
    [PacketHeader("finit")]
    public class FinitPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = "|")]
        public List<FinitSubPacket?>? SubPackets { get; set; }
    }
}