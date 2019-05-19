using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.MiniMap
{
    [PacketHeader("rsfp")]
    public class RsfpPacket : PacketBase
    {
        [PacketIndex(0)]
        public long MapX { get; set; }

        [PacketIndex(1)]
        public long MapY { get; set; }
    }
}