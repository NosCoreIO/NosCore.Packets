using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("fauth")]
    public class FAuthPacket : IPacket
    {
        [PacketIndex(0)]
        public FamilyAuthority MemberType { get; set; }

        [PacketIndex(1)]
        public byte AuthorityId { get; set; }

        [PacketIndex(2)]
        public byte Value { get; set; }
    }
}