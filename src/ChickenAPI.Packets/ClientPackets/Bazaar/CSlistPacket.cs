using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_slist")]
    public class CSListPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Index { get; set; }


        [PacketIndex(1)]
        public BazaarStatusType Filter { get; set; }
    }
}