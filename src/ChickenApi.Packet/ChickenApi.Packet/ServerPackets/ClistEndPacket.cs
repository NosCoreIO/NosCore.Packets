using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("clist_end")]
    public class ClistEndPacket : IPacket
    {
    }
}