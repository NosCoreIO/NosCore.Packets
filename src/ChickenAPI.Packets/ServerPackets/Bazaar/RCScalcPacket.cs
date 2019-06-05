using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Bazaar
{
    [PacketHeader("rc_scalc")]
    public class RCScalcPacket : PacketBase
    {
        [PacketIndex(0)]
        [Range(1, long.MaxValue)]
        public long Price { get; set; }
        [PacketIndex(1)]
        public short RemainingAmount { get; set; }
        [PacketIndex(2)]
        public short Amount { get; set; }
        [PacketIndex(3)]
        public short Taxes { get; set; }
        [PacketIndex(4)]
        public long Total { get; set; }
    }
}