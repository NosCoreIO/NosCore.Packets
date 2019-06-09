using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_scalc")]
    public class CScalcPacket : PacketBase
    {
        [PacketIndex(0)]
        public long BazaarId { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        [Range(1, byte.MaxValue)]
        public byte Amount { get; set; }

        [PacketIndex(3)]
        [Range(1, byte.MaxValue)]
        public byte MaxAmount { get; set; }

        [PacketIndex(4)]
        [Range(1, long.MaxValue)]
        public long Price { get; set; }
    }
}