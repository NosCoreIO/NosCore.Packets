namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader(";")]
    public class GroupTalkPacket : IPacket
    {
        [PacketIndex(0, SerializeToEnd = true)]
        public string Message { get; set; }
    }
}