using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("info")]
    public class InfoPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}