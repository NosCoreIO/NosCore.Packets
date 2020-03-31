using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    [PacketHeader("bf")]
    public class BfPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2, ".")]
        public BuffElementSubPacket? Buff { get; set; }

        [PacketIndex(3)]
        public long BuffLevel { get; set; }

        public class BuffElementSubPacket : PacketBase
        {
            [PacketIndex(0)]
            public long ChargeValue { get; set; }

            [PacketIndex(1)]
            public long BuffId { get; set; }

            [PacketIndex(2)]
            public long Duration { get; set; }
        }
    }
}