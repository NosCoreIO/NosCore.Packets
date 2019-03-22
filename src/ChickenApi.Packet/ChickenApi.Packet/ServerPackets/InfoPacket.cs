namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("info")]
    public class InfoPacket : IPacket
    {
        [PacketIndex(0, false, false)]
        public string Message { get; set; }
    }
}