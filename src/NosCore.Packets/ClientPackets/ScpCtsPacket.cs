//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets
{
    [PacketHeader("sc_p_cts", Scope.InGame)]
    public class ScpCtsPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Data { get; set; }
    }
}