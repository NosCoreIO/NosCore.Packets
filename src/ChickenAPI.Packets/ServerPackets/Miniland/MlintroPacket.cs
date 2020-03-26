using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlintro")]
    public class MlintroPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Intro { get; set; }
    }
}