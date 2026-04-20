//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Arena final score packet (team arena). Sent at match end with per-team tallies.
    // Format: ta_f 0 {victoriousTeam} {arenaType} {score1} {life1} {call1} {score2} {life2} {call2}
    [PacketHeader("ta_f", Scope.InGame)]
    public class TaFPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; }

        [PacketIndex(1)]
        public byte VictoriousTeam { get; set; }

        [PacketIndex(2)]
        public byte ArenaType { get; set; }

        [PacketIndex(3)]
        public int ScoreTeam1 { get; set; }

        [PacketIndex(4)]
        public int LifeTeam1 { get; set; }

        [PacketIndex(5)]
        public int CallTeam1 { get; set; }

        [PacketIndex(6)]
        public int ScoreTeam2 { get; set; }

        [PacketIndex(7)]
        public int LifeTeam2 { get; set; }

        [PacketIndex(8)]
        public int CallTeam2 { get; set; }
    }
}
