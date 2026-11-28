//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // A raid team's state. Seen: raid 1 1 on joining the team and raid 1 0 on entering the raid, raid 2 with
    // the leader's id (-1 once out of the team), then raid 5 0 and raid 4 with no value once inside. The
    // members' HP and MP (raid 3) are RaidMemberStatsPacket.
    [PacketHeader("raid", Scope.InGame, AllowDuplicateHeader = true)]
    public class RaidPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public long? Value { get; set; }
    }
}
