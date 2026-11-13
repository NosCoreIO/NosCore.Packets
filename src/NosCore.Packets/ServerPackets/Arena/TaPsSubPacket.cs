//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    [PacketHeader("ta_ps_sub_packet", Scope.InGame)]
    public class TaPsSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long? CharacterId { get; set; }

        [PacketIndex(1)]
        public int? HpPercent { get; set; }

        [PacketIndex(2)]
        public int? MpPercent { get; set; }
    }
}
