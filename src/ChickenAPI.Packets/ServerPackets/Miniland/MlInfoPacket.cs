using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlinfo")]
    public class MlinfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Unknown1 { get; set; }

        [PacketIndex(1)]
        public long MinilandPoint { get; set; }

        [PacketIndex(2)]
        public byte Unknown2 { get; set; }

        [PacketIndex(3)]
        public int DailyVisitCount { get; set; }

        [PacketIndex(4)]
        public int VisitCount { get; set; }

        [PacketIndex(5)]
        public byte Unknown3 { get; set; }

        [PacketIndex(6)]
        public MinilandState MinilandState { get; set; }

        [PacketIndex(7)]
        public string? WelcomeMusicInfo { get; set; }

        [PacketIndex(8)]
        public string? MinilandWelcomeMessage { get; set; }
    }
}