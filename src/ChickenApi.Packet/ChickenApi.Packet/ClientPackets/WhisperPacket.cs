namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("/")]
    public class WhisperPacket : IPacket
    {
        [PacketIndex(0, SerializeToEnd = true)]
        public string Message { get; set; }
    }
}