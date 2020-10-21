//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Bank
{
    [PacketHeader("gb", Scope.InGame)]
    public class GbPacket : PacketBase
    {
        [PacketIndex(0)]
        public BankActionType Type { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long GoldBank { get; set; }

        [PacketIndex(2)]
        [Range(0, int.MaxValue)]
        public int Gold { get; set; }

        [PacketIndex(3)]
        public BankRankType BankRank { get; set; }

        [PacketIndex(4)]
        [Range(0, int.MaxValue)]
        public int BankTax { get; set; }
    }
}
