using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Chats
{
    [PacketHeader("talk")]
    public class TalkPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}