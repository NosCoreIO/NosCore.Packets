using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    [PacketHeader("pairy")]
    public class PairyPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int FairyMoveType { get; set; }

        [PacketIndex(3)]
        public ElementType Element { get; set; }

        [PacketIndex(4)]
        public int ElementRate { get; set; }

        [PacketIndex(5)]
        public int Morph { get; set; }
    }
}