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
    [PacketHeader("sell_list", Scope.InGame | Scope.InTrade)]
    public class SellListPacket : PacketBase
    {
        [PacketIndex(0)]
        public long ValueSold { get; set; }

        [PacketListIndex(1)]
        public List<SellListSubPacket?>? SellListSubPacket { get; set; }
    }
}