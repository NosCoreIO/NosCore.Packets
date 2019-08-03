using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Quicklist
{
    [PacketHeader("qset")]
    public class QsetClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public QSetType Type { get; set; }

        [PacketIndex(1)]
        public short OriginQuickList { get; set; }

        [PacketIndex(2)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(3)]
        public QsetClientSubPacket Data { get; set; }
    }
}