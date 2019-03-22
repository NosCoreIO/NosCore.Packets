using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("f_stash_end")]
    public class FStashEndPacket : IPacket
    {
    }
}