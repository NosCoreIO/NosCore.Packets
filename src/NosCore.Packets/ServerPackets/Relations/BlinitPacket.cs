using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Relations
{
    [PacketHeader("blinit")]
    public class BlinitPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = "|")]
        public List<BlinitSubPacket?>? SubPackets { get; set; }
    }
}