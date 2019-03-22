using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("c_map")]
    public class CMapPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public short Id { get; set; }

        [PacketIndex(2)]
        public bool MapType { get; set; }
    }
}