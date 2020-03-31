using NosCore.Packets.Attributes;
using System.Collections.Generic;

namespace NosCore.Packets.ServerPackets.Quicklist
{
    [PacketHeader("qslot")]
    public class QSlotPacket : PacketBase
    {
        [PacketIndex(0)]
        public long Slot { get; set; }

        [PacketIndex(1)]
        public List<QsetClientSubPacket?>? Data { get; set; }
    }
}