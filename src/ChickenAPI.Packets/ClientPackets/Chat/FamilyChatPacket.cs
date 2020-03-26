using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Chat
{
    [PacketHeader(":")]
    public class FamilyChatPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}