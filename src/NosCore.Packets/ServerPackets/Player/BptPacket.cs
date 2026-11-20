//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("bpt", Scope.InGame)]
    public class BptPacket : PacketBase
    {
        // 48 battle-pass countdowns in minutes, such as the season's end; -997 and -999 mark unused ones.
        [PacketListIndex(0, ListSeparator = " ")]
        public List<long> MinutesRemaining { get; set; } = [];
    }
}
