using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Chat
{
    [PacketHeader(";")]
    public class GroupTalkPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}