using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Miniland
{
    public class MloInfoPacketSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long MinimumPoints { get; set; }

        [PacketIndex(1)]
        public long MaximumPoints { get; set; }
    }
}
