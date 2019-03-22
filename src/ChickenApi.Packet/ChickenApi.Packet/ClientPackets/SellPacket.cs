using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("sell")]
    public class SellPacket : IPacket
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