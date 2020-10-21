//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("m_shop", Scope.InGame)]
    public class MShopPacket : PacketBase
    {
        [PacketIndex(0)]
        public CreateShopPacketType Type { get; set; }

        [PacketListIndex(1, IsOptional = true, Length = 20)]
        public List<MShopItemSubPacket?>? ItemList { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public string? Name { get; set; }
    }
}