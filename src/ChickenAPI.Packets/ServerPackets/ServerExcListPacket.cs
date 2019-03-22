using System.Collections.Generic;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
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