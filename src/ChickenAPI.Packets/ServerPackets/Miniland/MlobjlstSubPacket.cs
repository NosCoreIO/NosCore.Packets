using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    public class MlobjlstSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public bool InUse { get; set; }

        [PacketIndex(2)]
        public short MapX { get; set; }

        [PacketIndex(3)]
        public short MapY { get; set; }

        [PacketIndex(4)]
        public byte Width { get; set; }

        [PacketIndex(5)]
        public byte Height { get; set; }

        [PacketIndex(6)]
        public int DurabilityPoint { get; set; }

        [PacketIndex(7)]
        public byte Unknown { get; set; }

        [PacketIndex(8)]
        public bool Unknown2 { get; set; }

        [PacketIndex(9)]
        public bool Unknown3 { get; set; }
    }
}