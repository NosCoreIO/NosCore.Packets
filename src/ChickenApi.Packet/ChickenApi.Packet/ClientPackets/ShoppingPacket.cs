using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("shopping")]
    public class ShoppingPacket : IPacket
    {
        [PacketIndex(0)]
        public short ShopType { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; }

        [PacketIndex(2)]
        public VisualType VisualType { get; set; }

        [PacketIndex(3)]
        public long VisualId { get; set; }
    }
}