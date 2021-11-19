//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Player
{
    [PacketHeader("bpt", Scope.InGame)]
    public class BptPacket : PacketBase
    {
        [PacketIndex(0)]
        public long MinutesUntilSeasonEnd { get; set; }
    }
}
