using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("m_shop_subpacket")]
    public class MShopItemSubPacket : IPacket
    {
        [PacketIndex(0)]
        public PocketType Type { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        [Range(0, short.MaxValue)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        [Range(0, long.MaxValue)]
        public long Price { get; set; }
    }
}