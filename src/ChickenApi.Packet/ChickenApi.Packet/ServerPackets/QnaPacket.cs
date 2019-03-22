namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("qna")]
    public class QnaPacket : IPacket
    {
        [PacketIndex(0)]
        public IPacket YesPacket { get; set; }

        [PacketIndex(1)]
        public string Question { get; set; }
    }
}