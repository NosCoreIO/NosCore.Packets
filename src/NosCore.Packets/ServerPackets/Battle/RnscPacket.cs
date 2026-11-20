//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    // The running score of the current map: 0 on entering it, then each kill adds 1 plus 5 for every kill
    // chained before it, and a room cleared in a time-space adds 50.
    [PacketHeader("rnsc", Scope.InGame)]
    public class RnscPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Score { get; set; }
    }
}
