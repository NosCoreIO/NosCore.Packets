using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Miniland
{
    [PacketHeader("rmvobj")]
    public class RmvobjPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }
    }
}