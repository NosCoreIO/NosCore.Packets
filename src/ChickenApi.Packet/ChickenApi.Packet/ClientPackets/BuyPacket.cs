using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("buy")]
    public class BuyPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short Slot { get; set; }

        [PacketIndex(3)]
        [Range(1, short.MaxValue)]
        public short Amount { get; set; }
    }
}