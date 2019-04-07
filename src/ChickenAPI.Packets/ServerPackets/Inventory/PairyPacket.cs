using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Inventory
{
    [PacketHeader("pairy")]
    public class PairyPacket : IPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int Unknown { get; set; }

        [PacketIndex(3)]
        public byte Element { get; set; }

        [PacketIndex(4)]
        public int ElementRate { get; set; }

        [PacketIndex(5)]
        public int Morph { get; set; }
    }
}