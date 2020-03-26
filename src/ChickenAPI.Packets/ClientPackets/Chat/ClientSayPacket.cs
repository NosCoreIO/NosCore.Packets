using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Chat
{
    [PacketHeader("say")]
    public class ClientSayPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}