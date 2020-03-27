using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("shop_end")]
    public class ShopEndPacket : PacketBase
    {
        [PacketIndex(0)]
        public ShopEndPacketType Type { get; set; }
    }
}