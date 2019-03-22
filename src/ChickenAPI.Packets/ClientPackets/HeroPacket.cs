using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("hero")]
    public class HeroPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}
