using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("frank_cts")]
    public class FrankCtsPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }
    }
}