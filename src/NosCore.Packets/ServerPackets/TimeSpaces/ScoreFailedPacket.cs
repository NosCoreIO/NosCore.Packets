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
    // A failed time-space run: its end state, then the ScorePacket fields up to the perfect flags, all zero.
    [PacketHeader("score", Scope.InGame, AllowDuplicateHeader = true)]
    public class ScoreFailedPacket : PacketBase
    {
        [PacketIndex(0)]
        public EndStateType EndState { get; set; }

        [PacketIndex(1)]
        public int Points { get; set; }

        [PacketIndex(2)]
        public int Experience { get; set; }

        [PacketIndex(3)]
        public int JobExperience { get; set; }

        [PacketIndex(4)]
        public int Gold { get; set; }

        [PacketIndex(5)]
        public byte DrawRewardCount { get; set; }

        [PacketIndex(6)]
        public short MonstersKilled { get; set; }

        [PacketIndex(7)]
        public short RoomsExplored { get; set; }

        [PacketIndex(8)]
        public short NpcsLeft { get; set; }

        // Written as a single 0 rather than one flag per category.
        [PacketListIndex(9, ListSeparator = "")]
        public List<bool> Perfect { get; set; } = [false];
    }
}
