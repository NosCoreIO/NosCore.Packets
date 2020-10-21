//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Exchanges
{
    [PacketHeader("exc_list", Scope.InGame | Scope.InTrade)]
    public class ExcListPacket : PacketBase
    {
        [PacketIndex(0)]
        [Range(0, long.MaxValue)]
        public long Gold { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long BankGold { get; set; }

        [PacketListIndex(2, SpecialSeparator = " ")]
        public List<ExcListSubPacket?>? SubPackets { get; set; }
    }
}