using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("talk")]
    public class TalkPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}