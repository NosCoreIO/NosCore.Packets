//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Arena spectate-mode toggle. ta_st {watch} — 0 disables the spectator camera,
    // 1+ enables one of the OpenNos watch modes.
    [PacketHeader("ta_st", Scope.InGame)]
    public class TaStPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Watch { get; set; }
    }
}
