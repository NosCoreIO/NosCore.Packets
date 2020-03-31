using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("shopping", BlockedByTrading = true)]
    public class ShoppingPacket : PacketBase
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