using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("m_shop")]
    public class MShopPacket : PacketBase
    {
        [PacketIndex(0)]
        public CreateShopPacketType Type { get; set; }

        [PacketIndex(1, IsOptional = true, Length = 20)]
        public List<MShopItemSubPacket?>? ItemList { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public string? Name { get; set; }
    }
}