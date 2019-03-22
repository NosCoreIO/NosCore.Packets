using System.ComponentModel.DataAnnotations;
using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("pinit_sub_packet")]
    public class PinitSubPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int GroupPosition { get; set; }

        [PacketIndex(3)]
        public byte Level { get; set; }

        [PacketIndex(4)]
        public string Name { get; set; }

        [PacketIndex(5)]
        public int Unknown { get; set; } //TODO: Find what this is made for

        [PacketIndex(6)]
        public GenderType Gender { get; set; }

        [PacketIndex(7)]
        public short Race { get; set; }

        [PacketIndex(8)]
        public short Morph { get; set; }

        [PacketIndex(9)]
        public byte HeroLevel { get; set; }
    }
}