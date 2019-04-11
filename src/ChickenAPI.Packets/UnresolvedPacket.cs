using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets
{
    public class UnresolvedPacket : PacketBase
    {
        [PacketIndex(0)]
        public string Body { get; set; }
    }
}