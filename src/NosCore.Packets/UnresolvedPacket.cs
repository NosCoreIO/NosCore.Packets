using NosCore.Packets.Attributes;

namespace NosCore.Packets
{
    public class UnresolvedPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Body { get; set; }
    }
}