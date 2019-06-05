using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_slist")]
    public class CSListPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Index { get; set; }


        [PacketIndex(1)]
        public byte Filter { get; set; }
    }
}