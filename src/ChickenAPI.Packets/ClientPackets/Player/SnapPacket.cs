using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Player
{
    [PacketHeader("snap")]
    public class SnapPacket : IPacket
    {
    }
}