using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Exchanges
{
    [PacketHeader("exc_close")]
    public class ExcClosePacket : PacketBase
    {
        [PacketIndex(0)]
        public ExchangeResultType Type { get; set; }
    }
}