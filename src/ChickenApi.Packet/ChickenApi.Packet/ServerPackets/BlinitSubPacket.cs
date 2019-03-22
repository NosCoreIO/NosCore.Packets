namespace ChickenApi.Packet.ServerPackets
{
    public class BlinitSubPacket : IPacket
    {
        [PacketIndex(0)]
        public long RelatedCharacterId { get; set; }

        [PacketIndex(1)]
        public string CharacterName { get; set; }
    }
}