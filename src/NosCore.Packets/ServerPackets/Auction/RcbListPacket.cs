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
    [PacketHeader("rc_blist", Scope.InGame)]
    public class RcbListPacket : PacketBase
    {
        [PacketIndex(0)]
        public long PageIndex { get; set; }

        [PacketListIndex(1, SpecialSeparator = "|")]
        public List<RcbListElementPacket?>? Items { get; set; }

        public class RcbListElementPacket : PacketBase
        {
            [PacketIndex(0)]
            public long AuctionId { get; set; }

            [PacketIndex(1)]
            public long OwnerId { get; set; }

            [PacketIndex(2)]
            public string? OwnerName { get; set; }

            [PacketIndex(3)]
            public long ItemId { get; set; }

            [PacketIndex(4)]
            public short Amount { get; set; }

            [PacketIndex(5)]
            public bool IsPackage { get; set; }

            [PacketIndex(6)]
            public long Price { get; set; }

            [PacketIndex(7)]
            public long MinutesLeft { get; set; }

            /// <summary>
            ///     Todo find signification but default known value is 2
            /// </summary>
            [PacketIndex(8)]
            public bool Unknown1 { get; set; }

            [PacketIndex(9)]
            public long Unknown { get; set; }

            [PacketIndex(10)]
            public long Rarity { get; set; }

            [PacketIndex(11)]
            public long Upgrade { get; set; }

            [PacketIndex(12, RemoveHeader = true)]
            public EInfoPacket? EInfo { get; set; }
        }
    }
}