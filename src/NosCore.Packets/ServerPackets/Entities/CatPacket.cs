//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Entities
{
    [PacketHeader("ca_t", Scope.InGame)]
    public class CatPacket : PacketBase
    {
        [PacketIndex(0)]
        public long EntityId { get; set; }

        [PacketIndex(2)]
        public int Millisecond { get; set; }
    }
}