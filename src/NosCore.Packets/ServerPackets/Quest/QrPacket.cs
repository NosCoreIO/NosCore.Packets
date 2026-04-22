using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{
    [PacketHeader("qr", Scope.InGame)]
    public class QrPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte Unknown1 { get; set; } //TODO to find

        [PacketIndex(2)]
        public byte Unknown2 { get; set; } //TODO to find

        [PacketIndex(3)]
        public int Unknown3 { get; set; } //TODO to find

        [PacketIndex(4)]
        public int Unknown4 { get; set; } //TODO to find

        [PacketIndex(5)]
        public int Unknown5 { get; set; } //TODO to find

        [PacketIndex(6)]
        public int Unknown6 { get; set; } //TODO to find

        [PacketIndex(7)]
        public int Unknown7 { get; set; } //TODO to find

        [PacketIndex(8)]
        public int Unknown8 { get; set; } //TODO to find

        [PacketIndex(9)]
        public int Unknown9 { get; set; } //TODO to find

        [PacketIndex(10)]
        public int Unknown10 { get; set; } //TODO to find

        [PacketIndex(11)]
        public int Unknown11 { get; set; } //TODO to find

        [PacketIndex(12)]
        public int QuestId { get; set; }
    }
}
