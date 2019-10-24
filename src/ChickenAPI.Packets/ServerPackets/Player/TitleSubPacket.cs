using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    public class TitleSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short TitleId { get; set; }

        [PacketIndex(1)]
        public byte TitleStatus { get; set; }
    }
}