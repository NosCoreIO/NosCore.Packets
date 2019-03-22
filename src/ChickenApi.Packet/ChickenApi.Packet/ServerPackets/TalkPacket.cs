namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("talk")]
    public class TalkPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public string Message { get; set; }
    }
}