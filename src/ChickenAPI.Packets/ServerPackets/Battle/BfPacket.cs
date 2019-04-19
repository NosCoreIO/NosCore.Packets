using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Battle
{
    [PacketHeader("bf")]
    public class BfPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(3, ".")]
        public BuffElementSubPacket Buff { get; set; }

        [PacketIndex(4)]
        public long BuffLevel { get; set; }

        public class BuffElementSubPacket : PacketBase
        {
            [PacketIndex(2)]
            public long ChargeValue { get; set; }

            [PacketIndex(3)]
            public long BuffId { get; set; }

            [PacketIndex(4)]
            public long Duration { get; set; }
        }
    }
}