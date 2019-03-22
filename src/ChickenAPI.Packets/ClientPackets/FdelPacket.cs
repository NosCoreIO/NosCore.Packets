using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("fdel")]
    public class FdelPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}