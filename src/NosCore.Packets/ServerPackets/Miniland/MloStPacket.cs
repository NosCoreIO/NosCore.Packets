using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_st")]
    public class MloStPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Game { get; set; }
    }
}
