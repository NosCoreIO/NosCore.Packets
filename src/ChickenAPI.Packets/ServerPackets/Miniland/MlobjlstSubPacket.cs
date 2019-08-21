using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.ClientPackets.Miniland;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    public class MlobjlstSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1, RemoveHeader = true, SpecialSeparator = ".")]
        public MlobjPacket MlObjSubPacket { get; set; }
    }
}