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
    // Each member's HP in an Act 6 raid, about once a second; other raids send it with the HP in raid 3.
    [PacketHeader("raidfhp", Scope.InGame)]
    public class RaidfhpPacket : PacketBase
    {
        // 3 in every trace.
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketListIndex(1)]
        public List<RaidfMemberSubPacket?>? Members { get; set; }
    }
}
