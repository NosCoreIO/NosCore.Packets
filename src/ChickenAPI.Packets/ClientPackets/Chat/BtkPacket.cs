using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Chat
{
    [PacketHeader("btk")]
    public class BtkPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}