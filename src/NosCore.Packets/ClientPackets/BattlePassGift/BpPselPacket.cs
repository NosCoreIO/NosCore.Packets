//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.BattlePassGift
{
    [PacketHeader("bp_psel", Scope.InGame)]
    public class BpPselPacket : PacketBase
    {
        [PacketIndex(0)]
        public BattlePassItemType Type { get; set; }

        [PacketIndex(1)]
        public long BearingId { get; set; }
    }
}
