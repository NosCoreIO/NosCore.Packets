using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Shop
{
    [PacketHeader("s_memo")]
    public class SMemoPacket : PacketBase
    {
        [PacketIndex(0)]
        public SMemoType Type { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}