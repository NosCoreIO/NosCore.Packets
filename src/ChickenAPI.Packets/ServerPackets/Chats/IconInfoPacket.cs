using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Chats
{
    [PacketHeader("IconInfo")]
    public class IconInfoPacket : PacketBase
    {
        [PacketIndex(0, IsOptional = true)]
        public long? IconId { get; set; }
    }
}