using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("shop_end")]
    public class ShopEndPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }
    }
}