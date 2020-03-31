using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Relations
{
    [PacketHeader("bldel")]
    public class BlDelPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }
    }
}