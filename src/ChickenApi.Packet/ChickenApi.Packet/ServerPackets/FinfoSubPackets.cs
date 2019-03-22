namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("finfo_sub_packets")]
    public class FinfoSubPackets : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public bool IsConnected { get; set; }
    }
}