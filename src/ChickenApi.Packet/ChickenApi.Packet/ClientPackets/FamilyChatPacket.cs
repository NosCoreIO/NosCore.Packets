using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader(":")]
    public class FamilyChatPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}