using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_st")]
    public class MloStPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Game { get; set; }
    }
}
