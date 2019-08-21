using System.ComponentModel.DataAnnotations;
using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Exchanges
{
    [PacketHeader("req_exc")]
    public class ExchangeRequestPacket : PacketBase
    {
        [PacketIndex(0)]
        public RequestExchangeType RequestType { get; set; }

        [PacketIndex(1, IsOptional = true)]
        [Range(0, long.MaxValue)]
        public long? VisualId { get; set; }
    }
}