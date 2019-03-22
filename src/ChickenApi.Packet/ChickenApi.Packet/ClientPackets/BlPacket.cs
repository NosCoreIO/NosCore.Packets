namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("$bl")]
    public class BlPacket : IPacket
    {
        [PacketIndex(0)]
        public string CharacterName { get; set; }
    }
}