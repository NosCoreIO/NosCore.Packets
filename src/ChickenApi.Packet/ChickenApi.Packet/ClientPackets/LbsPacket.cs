﻿using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("lbs")]
    public class LbsPacket : IPacket
    {
        [PacketIndex(0)]
        public int Type { get; set; }
    }
}