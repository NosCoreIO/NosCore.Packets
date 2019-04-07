using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.MiniMap
{
    [PacketHeader("rsfp")]
    public class RsfpPacket : IPacket
    {
        [PacketIndex(0)]
        public long MapX { get; set; }

        [PacketIndex(1)]
        public long MapY { get; set; }
    }
}