using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    public class ExcListSubPacket : IPacket
    {
        [PacketIndex(0)]
        public PocketType PocketType { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        [Range(1, short.MaxValue)]
        public short Amount { get; set; }
    }
}