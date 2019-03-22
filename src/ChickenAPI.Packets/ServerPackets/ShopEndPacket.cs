using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("shop_end")]
    public class ShopEndPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }
    }
}