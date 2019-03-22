namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("qna")]
    public class QnaPacket : IPacket
    {
        [PacketIndex(0, IsReturnPacket = true)]
        public IPacket YesPacket { get; set; }

        [PacketIndex(1, SerializeToEnd = true)]
        public string Question { get; set; }
    }
}