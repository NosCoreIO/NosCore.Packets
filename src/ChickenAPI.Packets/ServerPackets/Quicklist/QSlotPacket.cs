using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;
using System.Collections.Generic;

namespace ChickenAPI.Packets.ServerPackets.Quicklist
{
    [PacketHeader("qslot")]
    public class QSlotPacket : PacketBase
    {
        [PacketIndex(0)]
        public long Slot { get; set; }

        [PacketIndex(1)]
        public List<QsetClientSubPacket> Data { get; set; }
    }
}