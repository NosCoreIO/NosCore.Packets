//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // The leader's look and levels stand for the team. A negative level is a hero level.
    [PacketHeader("rl_sub_packet", Scope.InGame)]
    public class ServerRlSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short RaidId { get; set; }

        [PacketIndex(1)]
        public short LevelMinimum { get; set; }

        [PacketIndex(2)]
        public short LevelMaximum { get; set; }

        [PacketIndex(3)]
        public string? LeaderName { get; set; }

        [PacketIndex(4)]
        public byte LeaderLevel { get; set; }

        [PacketIndex(5)]
        public short LeaderMorph { get; set; }

        [PacketIndex(6)]
        public CharacterClassType LeaderClass { get; set; }

        [PacketIndex(7)]
        public GenderType LeaderGender { get; set; }

        [PacketIndex(8)]
        public short MemberCount { get; set; }

        [PacketIndex(9)]
        public byte LeaderHeroLevel { get; set; }
    }
}
