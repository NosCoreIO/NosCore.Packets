using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("exc_close")]
    public class ExcClosePacket : IPacket
    {
        [PacketIndex(0)]
        public ExchangeResultType Type { get; set; }
    }
}