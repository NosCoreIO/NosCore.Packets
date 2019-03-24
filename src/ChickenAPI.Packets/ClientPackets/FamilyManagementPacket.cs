using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("fmg")]
    public class FamilyManagementPacket : IPacket
    {
        [PacketIndex(0)]
        public FamilyAuthority FamilyAuthorityType { get; set; }

        [PacketIndex(1)]
        public long TargetId { get; set; }
    }
}