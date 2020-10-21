//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_slist", Scope.InGame | Scope.InTrade)]
    public class CSListPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Index { get; set; }


        [PacketIndex(1)]
        public BazaarStatusType Filter { get; set; }
    }
}