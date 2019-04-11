using System;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Login
{
    [PacketHeader("NoS0575", AnonymousAccess = true)]
    public class NoS0575Packet : PacketBase
    {
        [PacketIndex(0)]
        public int Number { get; set; }

        [PacketIndex(1)]
        public string Name { get; set; }

        [PacketIndex(2)]
        public string Password { get; set; }

        [PacketIndex(3)]
        public Guid? ClientId { get; set; }

        [PacketIndex(4)]
        public string ClientData { get; set; }
    }
}