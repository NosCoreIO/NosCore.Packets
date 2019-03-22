namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("gjoin")]
    public class JoinFamilyPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public long CharacterId { get; set; }
    }
}