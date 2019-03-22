namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("blinit_subpacket")]
    public class BlinitSubPacket : IPacket
    {
        [PacketIndex(0)]
        public long RelatedCharacterId { get; set; }

        [PacketIndex(1)]
        public string CharacterName { get; set; }
    }
}