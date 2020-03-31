using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Relations
{
    [PacketHeader("$fl")]
    public class FlPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}