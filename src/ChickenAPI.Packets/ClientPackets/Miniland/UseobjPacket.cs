using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Miniland
{
    [PacketHeader("useobj")]
    public class UseobjPacket : PacketBase
    {
        [PacketIndex(0)]
        public string CharacterName { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }
    }
}
