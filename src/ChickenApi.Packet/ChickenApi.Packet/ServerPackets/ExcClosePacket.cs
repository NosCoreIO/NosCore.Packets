using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("exc_close")]
    public class ExcClosePacket : IPacket
    {
        [PacketIndex(0)]
        public ExchangeResultType Type { get; set; }
    }
}