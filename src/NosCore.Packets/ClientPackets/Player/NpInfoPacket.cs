//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Player
{
    /// <summary>
    /// Client-side request for the "new player info" page, e.g. <c>npinfo 0</c>.
    /// Mirrors the server-side <see cref="NosCore.Packets.ServerPackets.Player.NpInfoPacket"/>.
    /// </summary>
    [PacketHeader("npinfo", Scope.InGame)]
    public class NpInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Page { get; set; }
    }
}
