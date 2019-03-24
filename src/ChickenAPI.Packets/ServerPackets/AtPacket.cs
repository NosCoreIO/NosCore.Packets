using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("at")]
    public class AtPacket : IPacket
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        [PacketIndex(1)]
        public short MapId { get; set; }

        [PacketIndex(2)]
        public short PositionX { get; set; }

        [PacketIndex(3)]
        public short PositionY { get; set; }

        [PacketIndex(4)]
        public byte Direction { get; set; }

        [PacketIndex(5)]
        public byte Unknown1 { get; set; } //TODO to find

        [PacketIndex(6)]
        public int Music { get; set; }

        [PacketIndex(7)]
        public short Unknown2 { get; set; } //TODO to find

        [PacketIndex(8)]
        public short Unknown3 { get; set; } //TODO to find
    }
}