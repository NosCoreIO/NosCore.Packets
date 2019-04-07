using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Shops
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