using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Miniland
{
    [PacketHeader("rmvobj")]
    public class RmvobjPacket : IPacket
    {
        [PacketIndex(0)]
        public short Slot { get; set; }
    }
}