using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Visibility
{
    public class InAliveSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Hp { get; set; }

        [PacketIndex(1)]
        public int Mp { get; set; }
    }
}