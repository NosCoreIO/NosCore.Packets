using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("info")]
    public class InfoPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}