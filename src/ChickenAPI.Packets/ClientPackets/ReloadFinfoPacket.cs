using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("reloadfinfo")]
    public class ReloadFinfoPacket : IPacket
    {
    }
}