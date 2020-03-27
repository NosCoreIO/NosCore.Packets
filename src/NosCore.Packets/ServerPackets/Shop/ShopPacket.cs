using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("shop")]
    public class ShopPacket : PacketBase
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
        public string? Name { get; set; }
    }
}