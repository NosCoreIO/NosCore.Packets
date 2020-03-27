using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Relations
{
    [PacketHeader("fins")]
    public class FinsPacket : PacketBase
    {
        [PacketIndex(0)]
        public FinsPacketType Type { get; set; }

        [PacketIndex(1)]
        public long CharacterId { get; set; }
    }
}