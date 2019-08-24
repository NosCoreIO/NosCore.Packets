using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_lv")]
    public class MloLvPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Level { get; set; }
    }
}