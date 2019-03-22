using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("OK")]
    public class OkPacket : IPacket
    {
    }
}