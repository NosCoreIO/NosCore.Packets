using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Chats
{
    [PacketHeader("IconInfo")]
    public class IconInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public short IconId { get; set; }
    }
}