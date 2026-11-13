//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Team arena result window. The first three counts are the receiver's team (TeamType), the
    // last three its opponent's.
    [PacketHeader("ta_f", Scope.InGame)]
    public class TaFPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; }

        [PacketIndex(1)]
        public ArenaResultType Result { get; set; }

        [PacketIndex(2)]
        public ArenaTeamType TeamType { get; set; }

        [PacketIndex(3)]
        public int Won { get; set; }

        [PacketIndex(4)]
        public int LivesLeft { get; set; }

        [PacketIndex(5)]
        public int CallsLeft { get; set; }

        [PacketIndex(6)]
        public int OpponentWon { get; set; }

        [PacketIndex(7)]
        public int OpponentLivesLeft { get; set; }

        [PacketIndex(8)]
        public int OpponentCallsLeft { get; set; }
    }
}
