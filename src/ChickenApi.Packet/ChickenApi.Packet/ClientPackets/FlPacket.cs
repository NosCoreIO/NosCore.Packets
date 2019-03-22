namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("$fl")]
    public class FlPacket : IPacket
    {
        [PacketIndex(0)]
        public string CharacterName { get; set; }
    }
}