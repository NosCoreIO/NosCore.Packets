using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.Quicklist
{
    [PacketHeader("qset")]
    public class QsetClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public short OriginQuickList { get; set; }

        [PacketIndex(1)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(2, SpecialSeparator = ".")]
        public QsetClientSubPacket Data { get; set; }
    }
}