using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Chat
{
    [PacketHeader("hero")]
    public class HeroPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}
