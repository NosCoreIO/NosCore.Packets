namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("/")]
    public class WhisperPacket : IPacket
    {
        [PacketIndex(0)]
        public string Message { get; set; }
    }
}