using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("stash_all")]
    public class StashAllPacket : PacketBase
    {
        [PacketIndex(0)]
        public short WarehouseSize { get; set; }
    }
}
