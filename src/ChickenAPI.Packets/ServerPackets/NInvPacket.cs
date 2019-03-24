using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("n_inv")]
    public class NInvPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte Unknown { get; set; }

        [PacketIndex(3)]
        public byte ShopKind { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public List<NInvItemSubPacket> Items { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public List<short> Skills { get; set; }
    }
}