using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Families
{
    [PacketHeader("gidx")]
    public class GidxPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long FamilyId { get; set; }

        [PacketIndex(3)]
        public string FamilyName { get; set; }

        [PacketIndex(4, SpecialSeparator = "")]
        public string FamilyCustomRank { get; set; }

        [PacketIndex(5)]
        public byte FamilyLevel { get; set; }
    }
}