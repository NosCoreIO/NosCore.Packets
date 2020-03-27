using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("IconInfo")]
    public class IconInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public short IconId { get; set; }
    }
}