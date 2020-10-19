//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Exchanges
{
    [PacketHeader("exc_close")]
    public class ExcClosePacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public ExchangeResultType Type { get; set; }
    }
}