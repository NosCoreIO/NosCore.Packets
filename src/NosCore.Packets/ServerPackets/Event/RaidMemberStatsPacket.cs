//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // Each raid member's HP and MP, about once a second while inside the raid; Act 6 raids send raidfhp and
    // raidfmp instead.
    [PacketHeader("raid", Scope.InGame, AllowDuplicateHeader = true)]
    public class RaidMemberStatsPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } = 3;

        [PacketListIndex(1)]
        public List<RaidMemberStatSubPacket?>? Members { get; set; }
    }
}
