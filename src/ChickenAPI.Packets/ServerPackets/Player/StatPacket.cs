using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("stat")]
    public class StatPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Hp { get; set; }

        [PacketIndex(1)]
        public double HpMaximum { get; set; }

        [PacketIndex(2)]
        public int Mp { get; set; }

        [PacketIndex(3)]
        public double MpMaximum { get; set; }

        [PacketIndex(4)]
        public int Unknown { get; set; } //TODO to find

        [PacketIndex(5)]
        public double Option { get; set; }
    }
}