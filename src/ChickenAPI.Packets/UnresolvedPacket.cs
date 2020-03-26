using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets
{
    public class UnresolvedPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Body { get; set; }
    }
}