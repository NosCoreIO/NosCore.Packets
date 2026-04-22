//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Specialists
{
    // Max mate count display: sc_p_stc {MaxMateCount / 10}. OpenNos divides by 10
    // client-side and renders the result as the pet roster cap (default 30 → 3).
    [PacketHeader("sc_p_stc", Scope.InGame)]
    public class ScPStcPacket : PacketBase
    {
        [PacketIndex(0)]
        public int MaxMateCountTenths { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; } //TODO to find
    }
}
