//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // What a finished time-space's reward chest gave: its bonus and special items, then the one drawn.
    [PacketHeader("repay", Scope.InGame)]
    public class RepayPacket : PacketBase
    {
        [PacketListIndex(0, Length = 3)]
        public List<RepaySubPacketItem?>? BonusRewards { get; set; }

        [PacketListIndex(1, Length = 2)]
        public List<RepaySubPacketItem?>? SpecialRewards { get; set; }

        [PacketIndex(2, SpecialSeparator = ".")]
        public RepaySubPacketItem? DrawnReward { get; set; }
    }
}
