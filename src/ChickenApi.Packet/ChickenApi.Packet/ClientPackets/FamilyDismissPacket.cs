using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("glrm")]
    public class FamilyDismissPacket : IPacket
    {
    }
}