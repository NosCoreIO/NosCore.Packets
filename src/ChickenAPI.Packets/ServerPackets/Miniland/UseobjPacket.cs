using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("useobj")]
    public class UseObjPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Name { get; set; }

        [PacketIndex(1)]
        public long ObjectId { get; set; }
    }
}
