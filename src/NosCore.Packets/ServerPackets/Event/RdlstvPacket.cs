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
    // A listed Act 6 raid team as seen by a player outside it, answering rd 6 with the leader's name.
    [PacketHeader("rdlstv", Scope.InGame)]
    public class RdlstvPacket : PacketBase
    {
        [PacketIndex(0)]
        public short LevelMinimum { get; set; }

        [PacketIndex(1)]
        public short LevelMaximum { get; set; }

        [PacketIndex(2)]
        public short RaidId { get; set; }

        [PacketListIndex(3)]
        public List<RdlstSubPacket?>? Members { get; set; }
    }
}
