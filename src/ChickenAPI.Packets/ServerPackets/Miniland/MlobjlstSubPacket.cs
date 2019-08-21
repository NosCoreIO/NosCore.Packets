using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    public class MlobjlstSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public bool InUse { get; set; }

        [PacketIndex(2,RemoveHeader = true, SpecialSeparator = ".")]
        public MlobjSubPacket MlObjSubPacket { get; set; }
    }
}