//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Live arena match state. Broadcast each tick during a team arena to refresh the
    // scoreboard + countdown. Time is only non-zero for mid-match ticks (OpenNos
    // sends deciseconds remaining / 10 when type == 3).
    [PacketHeader("ta_m", Scope.InGame)]
    public class TaMPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public int ScoreTeam1 { get; set; }

        [PacketIndex(2)]
        public int ScoreTeam2 { get; set; }

        [PacketIndex(3)]
        public int TimeRemaining { get; set; }

        [PacketIndex(4)]
        public int Unknown { get; set; }
    }
}
