using ChickenAPI.Packets.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChickenAPI.Packets.ClientPackets.Miniland
{
    [PacketHeader("mg")]
    public class MinigamePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte Id { get; set; }

        [PacketIndex(2)]
        public short MinigameVNum { get; set; }

        [PacketIndex(3)]
        public int? Point { get; set; }
    }
}
