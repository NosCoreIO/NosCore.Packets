//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Exchanges
{
    [PacketHeader("req_exc", Scope.InGame)]
    public class ExchangeRequestPacket : PacketBase
    {
        [PacketIndex(0)]
        public RequestExchangeType RequestType { get; set; }

        [PacketIndex(1, IsOptional = true)]
        [Range(0, long.MaxValue)]
        public long? VisualId { get; set; }
    }
}