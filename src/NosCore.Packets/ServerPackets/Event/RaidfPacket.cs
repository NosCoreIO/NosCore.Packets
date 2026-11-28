//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // An Act 6 raid's team state, in place of raid. Seen: raidf 1 1 on joining the team and raidf 1 0 as it
    // enters the raid, raidf 2 with the leader's id (-1 once the raid is over), then raidf 5 0 and raidf 4 with
    // no value once inside.
    [PacketHeader("raidf", Scope.InGame)]
    public class RaidfPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public long? Value { get; set; }
    }
}
