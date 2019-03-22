namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("pulse")]
    public class PulsePacket : IPacket
    {
        [PacketIndex(0)]
        public int Tick { get; set; }
    }
}