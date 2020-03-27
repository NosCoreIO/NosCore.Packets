using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    public class TitleSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short TitleId { get; set; }

        [PacketIndex(1)]
        public byte TitleStatus { get; set; }
    }
}