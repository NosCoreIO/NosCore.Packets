//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Auction
{
    [PacketHeader("rc_slist", Scope.InGame)]
    public class RcsListPacket : PacketBase
    {
        [PacketIndex(0)]
        public int PageNumber { get; set; }

        [PacketListIndex(1, SpecialSeparator = "|")]
        public List<RcsListElementPacket?>? Items { get; set; }
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
            public BazaarStatusType Status { get; set; }

            [PacketIndex(8)]
            public long MinutesLeft { get; set; }

            [PacketIndex(9)]
            public bool IsSellerUsingMedal { get; set; }

            [PacketIndex(10)]
            public long Unknown { get; set; }

            [PacketIndex(11)]
            public long Rarity { get; set; }

            [PacketIndex(12)]
            public long Upgrade { get; set; }

            [PacketIndex(13, RemoveHeader = true)]
            public EInfoPacket? EInfo { get; set; }
        }
    }
}