using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("bldel")]
    public class BlDelPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}