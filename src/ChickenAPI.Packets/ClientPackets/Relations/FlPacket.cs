using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Relations
{
    [PacketHeader("$fl")]
    public class FlPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}