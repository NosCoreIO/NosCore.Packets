using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Movement
{
    [PacketHeader("rest")]
    public class SitPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Amount { get; set; }

        [PacketIndex(1, Length = -1)]
        public List<SitSubPacket> Users { get; set; }
    }
}