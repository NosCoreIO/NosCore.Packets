using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Shops
{
    [PacketHeader("sell")]
    public class SellPacket : PacketBase
    {
        [PacketIndex(2)]
        public short Data { get; set; }

        [PacketIndex(3)]
        public byte? Slot { get; set; }

        [PacketIndex(4)]
        [Range(1, short.MaxValue)]
        public short? Amount { get; set; }
    }
}