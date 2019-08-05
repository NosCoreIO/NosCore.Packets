using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ServerPackets.Quicklist
{
    //TODO fix issue when first param is optional and null
    public class QsetClientSubPacket : PacketBase
    {
        [PacketIndex(0)] //This should be nullable and optional
        public QSetType Type { get; set; }

        [PacketIndex(1, IsOptional = true)] //this shouldnt be nullable
        public short? OriginQuickList { get; set; }

        [PacketIndex(2)]
        public short OriginQuickListSlot { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? Data { get; set; }
    }
}