using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
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