using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Map
{
    [PacketHeader("mapout")]
    public class MapOutPacket : IPacket
    {
    }
}