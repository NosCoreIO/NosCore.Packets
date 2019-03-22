using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
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