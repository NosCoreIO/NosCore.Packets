using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Shops
{
    [PacketHeader("c_close")]
    public class CClosePacket : IPacket
    {
    }
}