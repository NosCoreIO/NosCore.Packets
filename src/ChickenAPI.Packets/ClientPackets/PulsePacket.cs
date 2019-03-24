﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("pulse")]
    public class PulsePacket : IPacket
    {
        [PacketIndex(0)]
        public int Tick { get; set; }
    }
}