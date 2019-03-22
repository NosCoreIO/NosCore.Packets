using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("glist")]
    public class GListPacket : IPacket
    {
        [PacketIndex(1)]
        public byte Type { get; set; }
    }
}