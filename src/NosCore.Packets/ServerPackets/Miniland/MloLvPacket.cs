using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_lv")]
    public class MloLvPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Level { get; set; }
    }
}