using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("fdel")]
    public class FdelPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}