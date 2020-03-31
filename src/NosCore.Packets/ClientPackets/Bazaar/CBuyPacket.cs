using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_buy", BlockedByTrading = true)]
    public class CBuyPacket : PacketBase
    {
        [PacketIndex(0)]
        public long BazaarId { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        [Range(1, short.MaxValue)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        [Range(1, long.MaxValue)]
        public long Price { get; set; }
    }
}
