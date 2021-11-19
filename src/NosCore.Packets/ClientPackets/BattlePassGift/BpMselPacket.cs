//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.BattlePassGift
{
    [PacketHeader("bp_msel", Scope.InGame)]
    public class BpMselPacket : PacketBase
    {
        [PacketIndex(0)]
        public long QuestId { get; set; }
    }
}
