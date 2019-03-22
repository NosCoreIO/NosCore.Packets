namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("info")]
    public class InfoPacket : IPacket
    {
        [PacketIndex(0, true, false, false)]
        public string Message { get; set; }
    }
}