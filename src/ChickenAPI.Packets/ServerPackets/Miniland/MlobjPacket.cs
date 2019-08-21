using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;
using ChickenAPI.Packets.ServerPackets.Miniland;

namespace ChickenAPI.Packets.ClientPackets.Miniland
{
    [PacketHeader("mlobj")]
    public class MlobjPacket : PacketBase
    {
        [PacketIndex(0)]
        public bool InUse { get; set; }

        [PacketIndex(1)]
        public short MapX { get; set; }

        [PacketIndex(2)]
        public short MapY { get; set; }

        [PacketIndex(3)]
        public byte Width { get; set; }

        [PacketIndex(4)]
        public byte Height { get; set; }

        [PacketIndex(5)]
        public byte Unknown { get; set; }

        [PacketIndex(6)]
        public int DurabilityPoint { get; set; }

        [PacketIndex(7)]
        public bool Unknown2 { get; set; }

        [PacketIndex(8)]
        public bool IsWarehouse { get; set; }
    }
}