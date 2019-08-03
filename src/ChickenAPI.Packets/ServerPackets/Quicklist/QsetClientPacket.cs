using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Quicklist
{
    [PacketHeader("qset")]
    public class QsetClientPacket : PacketBase
    {
        [PacketIndex(0)]
        public short OriginQuickList { get; set; }

        [PacketIndex(1)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(2)]
        public QsetClientSubPacket Data { get; set; }
    }
}