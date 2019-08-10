using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Miniland
{
    [PacketHeader("addobj")]
    public class AddobjPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public short PositionX { get; set; }

        [PacketIndex(2)]
        public short PositionY { get; set; }
    }
}
