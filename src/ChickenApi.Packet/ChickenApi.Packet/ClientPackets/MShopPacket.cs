using System.Collections.Generic;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("m_shop")]
    public class MShopPacket : IPacket
    {
        [PacketIndex(0)]
        public CreateShopPacketType Type { get; set; }

        [PacketIndex(1, IsOptional = true, Length = 20)]
        public List<MShopItemSubPacket> ItemList { get; set; }

        [PacketIndex(2, SerializeToEnd = true, IsOptional = true)]
        public string Name { get; set; }
    }
}