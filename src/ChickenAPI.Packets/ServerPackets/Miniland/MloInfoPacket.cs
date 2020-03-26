using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlo_info")]
    public class MloInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public bool IsOwner { get; set; }

        [PacketIndex(1)]
        public short ObjectVNum { get; set; }

        [PacketIndex(2)]
        public byte Slot { get; set; }

        [PacketIndex(3)]
        public long MinilandPoints { get; set; }

        [PacketIndex(4)]
        public bool LawDurability { get; set; }

        [PacketIndex(5)]
        public bool IsFull { get; set; }

        [PacketIndex(6, SpecialSeparator = " ")]
        public MloInfoPacketSubPacket?[]? MinigamePoints { get; set; }
    }
}
