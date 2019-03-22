using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("btk")]
    public class BtkPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}