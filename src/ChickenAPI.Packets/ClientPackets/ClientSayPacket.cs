using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("say")]
    public class ClientSayPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}