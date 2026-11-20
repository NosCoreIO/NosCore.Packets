//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using System.Collections.Generic;

namespace NosCore.Packets.ServerPackets.TimeSpaces
{
    // The Mission Clear window of a time-space. A failed run is a ScoreFailedPacket.
    [PacketHeader("score", Scope.InGame, AllowDuplicateHeader = true)]
    public class ScorePacket : PacketBase
    {
        // The line has an empty field before the end state, which only the cleared run carries.
        [PacketIndex(0)]
        public string ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(1)]
        public EndStateType EndState { get; set; } = EndStateType.Success;

        // After the level penalty.
        [PacketIndex(2)]
        public int Points { get; set; }

        [PacketIndex(3)]
        public int Experience { get; set; }

        [PacketIndex(4)]
        public int JobExperience { get; set; }

        [PacketIndex(5)]
        public int Gold { get; set; }

        [PacketIndex(6)]
        public byte DrawRewardCount { get; set; }

        [PacketIndex(7)]
        public short MonstersKilled { get; set; }

        [PacketIndex(8)]
        public short RoomsExplored { get; set; }

        [PacketIndex(9)]
        public short NpcsLeft { get; set; }

        // Whether every monster was killed, every room explored and every NPC kept alive, in that order.
        [PacketListIndex(10, ListSeparator = "")]
        public List<bool> Perfect { get; set; } = [false, false, false];

        [PacketIndex(11)]
        public TimeSpaceClearType ClearType { get; set; }

        // 15 for a level 76 and a level 98 character, 1 for a level 6 to 20 one, whatever the run.
        [PacketIndex(12)]
        public byte Unknown { get; set; }
    }
}
