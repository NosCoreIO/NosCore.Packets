namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("in_alive_subpacket")]
    public class InAliveSubPacket : IPacket
    {
        [PacketIndex(0)]
        public int Hp { get; set; }

        [PacketIndex(1)]
        public int Mp { get; set; }
    }
}