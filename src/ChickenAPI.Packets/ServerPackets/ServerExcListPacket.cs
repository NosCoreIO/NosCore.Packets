using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("exc_list")]
    public class ServerExcListPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long? Gold { get; set; }

        [PacketIndex(3)]
        public long? BankGold { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public List<ServerExcListSubPacket> SubPackets { get; set; }
    }
}