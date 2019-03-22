using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("tit")]
    public class TitPacket : IPacket
    {
        [PacketIndex(0)]
        public string ClassType { get; set; }

        [PacketIndex(1)]
        public string Name { get; set; }
    }
}