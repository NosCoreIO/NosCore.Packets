﻿namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("guri")]
    public class GuriPacket : IPacket
    {
        [PacketIndex(0)]
        public int Type { get; set; }

        [PacketIndex(1)]
        public int Argument { get; set; }

        [PacketIndex(2)]
        public long? VisualEntityId { get; set; }

        [PacketIndex(3)]
        public int Data { get; set; }

        [PacketIndex(4, true, false, false, SerializeToEnd = true)]
        public string Value { get; set; }
    }
}