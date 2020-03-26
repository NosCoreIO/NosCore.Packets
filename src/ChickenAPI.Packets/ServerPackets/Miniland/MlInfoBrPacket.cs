using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlinfobr")]
    public class MlInfoBrPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Unknown1 { get; set; }

        [PacketIndex(1)]
        public string? Name { get; set; }

        [PacketIndex(2)]
        public int DailyVisitCount { get; set; }

        [PacketIndex(3)]
        public int VisitCount { get; set; }

        [PacketIndex(4)]
        public byte Unknown2 { get; set; }

        [PacketIndex(5)]
        public string? MinilandMessage { get; set; }
    }
}