using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.ServerPackets.Inventory;

namespace ChickenAPI.Packets.ServerPackets.Auction
{
    [PacketHeader("rc_slist")]
    public class RcsListPacket : PacketBase
    {
        [PacketIndex(0)]
        public int PageNumber { get; set; }

        [PacketIndex(1, SpecialSeparator= "|")]
        public List<RcsListElementPacket> Items { get; set; }

        [PacketHeader("rc_slist_element")]
        public class RcsListElementPacket : PacketBase
        {
            [PacketIndex(0)]
            public long AuctionId { get; set; }

            [PacketIndex(1)]
            public long OwnerId { get; set; }

            [PacketIndex(2)]
            public long ItemId { get; set; }

            [PacketIndex(3)]
            public long SoldAmount { get; set; }

            [PacketIndex(4)]
            public long Amount { get; set; }

            [PacketIndex(5)]
            public bool IsPackage { get; set; }

            [PacketIndex(6)]
            public long Price { get; set; }

            [PacketIndex(7)]
            public long MinutesLeft { get; set; }

            [PacketIndex(8)]
            public bool IsSellerUsingMedal { get; set; }

            [PacketIndex(9)]
            public long Unknown { get; set; }

            [PacketIndex(10)]
            public long Rarity { get; set; }

            [PacketIndex(11)]
            public long Upgrade { get; set; }

            [PacketIndex(12)]
            public EInfoPacket EInfo { get; set; }
        }
    }
}