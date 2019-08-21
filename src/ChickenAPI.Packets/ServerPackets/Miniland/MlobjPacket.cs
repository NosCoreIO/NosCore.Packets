using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlobj")]
    public class MlobjPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public bool InUse { get; set; }

        [PacketIndex(2)]
        public MlobjSubPacket MlobjSubPacket { get; set; }
    }
}