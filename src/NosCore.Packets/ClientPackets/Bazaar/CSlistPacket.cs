using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Bazaar
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