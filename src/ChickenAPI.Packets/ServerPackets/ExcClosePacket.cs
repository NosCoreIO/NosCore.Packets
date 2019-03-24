using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("exc_close")]
    public class ExcClosePacket : IPacket
    {
        [PacketIndex(0)]
        public ExchangeResultType Type { get; set; }
    }
}