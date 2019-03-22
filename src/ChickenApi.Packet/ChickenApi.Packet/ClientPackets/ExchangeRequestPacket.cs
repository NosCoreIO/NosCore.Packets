﻿using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("req_exc")]
    public class ExchangeRequestPacket : IPacket
    {
        [PacketIndex(0)]
        public RequestExchangeType RequestType { get; set; }

        [PacketIndex(1, IsOptional = true)]
        [Range(0, long.MaxValue)]
        public long? VisualId { get; set; }
    }
}