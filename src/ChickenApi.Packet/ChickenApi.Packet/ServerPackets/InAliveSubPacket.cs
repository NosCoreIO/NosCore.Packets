namespace ChickenApi.Packet.ServerPackets
{
    public class InAliveSubPacket : IPacket
    {
        [PacketIndex(0)]
        public int Hp { get; set; }

        [PacketIndex(1)]
        public int Mp { get; set; }
    }
}