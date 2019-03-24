using System.Collections.Generic;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("pst")]
    public class PstPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int GroupOrder { get; set; }

        [PacketIndex(3)]
        public int HpLeft { get; set; }

        [PacketIndex(4)]
        public int MpLeft { get; set; }

        [PacketIndex(5)]
        public int HpLoad { get; set; }

        [PacketIndex(6)]
        public int MpLoad { get; set; }

        [PacketIndex(7)]
        public short Race { get; set; }

        [PacketIndex(8)]
        public GenderType Gender { get; set; }

        [PacketIndex(9)]
        public short Morph { get; set; }

        [PacketIndex(10, IsOptional = true)]
        public List<int> BuffIds { get; set; }
    }
}