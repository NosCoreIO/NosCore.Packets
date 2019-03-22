using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("reloadfinfo")]
    public class ReloadFinfoPacket : IPacket
    {
    }
}