using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Quicklist
{
    public class QsetClientSubPacket : PacketBase
    {
        [PacketIndex(0, IsOptional = true)]
        public QSetType? Type { get; set; }

        [PacketIndex(1)]
        public short OriginQuickList { get; set; }

        [PacketIndex(2)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? Data { get; set; }
    }
}