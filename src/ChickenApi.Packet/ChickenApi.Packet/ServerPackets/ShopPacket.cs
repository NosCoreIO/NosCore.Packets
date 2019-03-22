using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("shop")]
    public class ShopPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long ShopId { get; set; }

        [PacketIndex(3)]
        public byte MenuType { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public byte? ShopType { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public string Name { get; set; }
    }
}