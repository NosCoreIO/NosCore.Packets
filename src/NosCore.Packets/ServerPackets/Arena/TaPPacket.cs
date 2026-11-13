//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Team arena list: the receiver's team, its calls left and the opponent's, then the three
    // fighters of each team in fighting order, own team first.
    [PacketHeader("ta_p", Scope.InGame)]
    public class TaPPacket : PacketBase
    {
        [PacketIndex(0)]
        public TaWindowMode Type { get; set; }

        [PacketIndex(1)]
        public ArenaTeamType TeamType { get; set; }

        [PacketIndex(2)]
        public int CallsLeft { get; set; }

        [PacketIndex(3)]
        public int OpponentCallsLeft { get; set; }

        [PacketListIndex(4)]
        public List<TaPSubPacket?>? Fighters { get; set; }
    }
}
