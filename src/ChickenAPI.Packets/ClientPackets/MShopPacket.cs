using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("m_shop")]
    public class MShopPacket : IPacket
    {
        [PacketIndex(0)]
        public CreateShopPacketType Type { get; set; }

        [PacketIndex(1, IsOptional = true, Length = 20)]
        public List<MShopItemSubPacket> ItemList { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public string Name { get; set; }
    }
}