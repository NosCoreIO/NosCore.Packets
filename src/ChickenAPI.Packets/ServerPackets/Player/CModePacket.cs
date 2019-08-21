using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Player
{
    [PacketHeader("c_mode")]
    public class CModePacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short Morph { get; set; }

        [PacketIndex(3)]
        public byte MorphUpgrade { get; set; }

        [PacketIndex(4)]
        public short MorphDesign { get; set; }

        [PacketIndex(5)]
        public byte MorphBonus { get; set; }

        [PacketIndex(6)]
        public byte Size { get; set; }

        [PacketIndex(7)]
        public byte Unknown { get; set; }
    }
}