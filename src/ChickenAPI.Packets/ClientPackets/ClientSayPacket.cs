﻿using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("say")]
    public class ClientSayPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}