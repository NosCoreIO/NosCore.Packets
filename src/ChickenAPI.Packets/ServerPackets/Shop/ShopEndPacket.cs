using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Shop
{
    [PacketHeader("shop_end")]
    public class ShopEndPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }
    }
}