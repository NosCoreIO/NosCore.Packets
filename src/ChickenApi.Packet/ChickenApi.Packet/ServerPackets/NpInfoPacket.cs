namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("npinfo")]
    public class NpInfoPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Page { get; set; }
    }
}