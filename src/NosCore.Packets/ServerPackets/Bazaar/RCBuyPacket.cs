using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Bazaar
{
    [PacketHeader("rc_buy")]
    public class RCBuyPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }
        [PacketIndex(1)]
        public short VNum { get; set; }
        [PacketIndex(2)]
        public long Owner { get; set; }
        [PacketIndex(3)]
        public short Amount { get; set; }
        [PacketIndex(4)]
        public long Price { get; set; }
        [PacketIndex(5)]
        public byte Unknown1 { get; set; }
        [PacketIndex(6)]
        public int Unknown2 { get; set; }
        [PacketIndex(7)]
        public byte Unknown3 { get; set; }
    }
}