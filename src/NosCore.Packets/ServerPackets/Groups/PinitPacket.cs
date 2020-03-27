using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Groups
{
    [PacketHeader("pinit")]
    public class PinitPacket : PacketBase
    {
        [PacketIndex(0)]
        public int GroupSize { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public List<PinitSubPacket?>? PinitSubPackets { get; set; }
    }
}