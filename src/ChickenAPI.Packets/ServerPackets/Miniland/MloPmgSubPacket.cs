using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    public class MloPmgSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short BoxVNum { get; set; }

        [PacketIndex(1)]
        public long BoxAmount { get; set; }
    }
}