using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_scalc")]
    public class CScalcPacket : PacketBase
    {
        [PacketIndex(0)]
        public long BazaarId { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        public byte Amount { get; set; }

        [PacketIndex(3)]
        public byte MaxAmount { get; set; }

        [PacketIndex(4)]
        public long Price { get; set; }
    }
}