//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // The raid's objective counters for the room the player is in, and the lives its team has left. Sent on
    // entering a room, on each kill that counts and on each death in the team.
    [PacketHeader("raidmbf", Scope.InGame)]
    public class RaidmbfPacket : PacketBase
    {
        [PacketIndex(0)]
        public short MonsterGoal { get; set; }

        [PacketIndex(1)]
        public short MonstersLeft { get; set; }

        // A second counter, counted down apart from the monsters: 3 beside the 11 Cubies of the Mother Cuby
        // raid's first room, 0 in a boss room.
        [PacketIndex(2)]
        public short SecondGoal { get; set; }

        [PacketIndex(3)]
        public short SecondGoalLeft { get; set; }

        // The team's size at the start, less one for each death since.
        [PacketIndex(4)]
        public short LivesLeft { get; set; }

        [PacketIndex(5)]
        public short Lives { get; set; }

        // The same as raidbf's last field.
        [PacketIndex(6)]
        public byte Unknown { get; set; }
    }
}
