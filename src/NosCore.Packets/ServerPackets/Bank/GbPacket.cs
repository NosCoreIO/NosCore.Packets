using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Bank
{
    [PacketHeader("gb")]
    public class GbPacket : PacketBase
    {
        [PacketIndex(0)]
        public BankOpeningType Type { get; set; }

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
