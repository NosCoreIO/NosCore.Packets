namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("blins")]
    public class BlInsPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}