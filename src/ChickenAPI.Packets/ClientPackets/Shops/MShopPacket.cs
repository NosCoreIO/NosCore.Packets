using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Shops
{
    [PacketHeader("m_shop")]
    public class MShopPacket : PacketBase
    {
        [PacketIndex(0)]
        public CreateShopPacketType Type { get; set; }

        [PacketIndex(1, IsOptional = true, Length = 20)]
        public List<MShopItemSubPacket> ItemList { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public string Name { get; set; }
    }
}