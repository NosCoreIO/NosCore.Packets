using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("bldel")]
    public class BlDelPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}