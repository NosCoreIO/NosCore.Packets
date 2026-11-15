//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.RainbowBattle
{
    // Which team holds a Rainbow Crystal, sent for each crystal NPC on the battle map.
    [PacketHeader("fbt", Scope.InGame, AllowDuplicateHeader = true)]
    public class FbtCrystalPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } = 6;

        [PacketIndex(1)]
        public long NpcId { get; set; }

        [PacketIndex(2)]
        public RainbowCrystalSize Size { get; set; }

        [PacketIndex(3)]
        public RainbowBattleTeamType Team { get; set; }
    }
}
