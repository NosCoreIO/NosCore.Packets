using System;
using System.Collections.Generic;
using System.Text;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Bank
{
    [PacketHeader("gb")]
    public class GbPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public long GoldBank { get; set; }

        [PacketIndex(2)]
        public long Gold { get; set; }

        [PacketIndex(3)]
        public BankRankType BankRank { get; set; }

        [PacketIndex(4)]
        public int BankTax { get; set; }
    }
}
