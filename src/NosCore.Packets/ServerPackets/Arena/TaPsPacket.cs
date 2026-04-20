//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // Arena spectator/survivor list. Single opaque "groups" payload server-side renders
    // (see TaPPacket for the reasoning around keeping this unstructured).
    [PacketHeader("ta_ps", Scope.InGame)]
    public class TaPsPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Groups { get; set; }
    }
}
