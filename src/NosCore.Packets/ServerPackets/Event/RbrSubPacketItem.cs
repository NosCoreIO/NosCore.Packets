using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Event
{
    public class RbrSubPacketItem : PacketBase
    {
        [PacketIndex(0)]
        public short? ItemId { get; set; }

        [PacketIndex(1)]
        public short Quantity { get; set; }
    }
}