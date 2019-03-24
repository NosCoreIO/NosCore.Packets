using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("exc_list")]
    public class ExcListPacket : IPacket
    {
        [PacketIndex(0)]
        [Range(0, long.MaxValue)]
        public long Gold { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long BankGold { get; set; }

        [PacketIndex(2, SpecialSeparator = " ")]
        public List<ExcListSubPacket> SubPackets { get; set; }
    }
}