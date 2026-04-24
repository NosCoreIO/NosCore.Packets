//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.UI
{
    /// <summary>
    /// Client-side request to open the in-game mall UI, e.g. <c>mall 50</c>.
    /// Mirrors the server-side <see cref="NosCore.Packets.ServerPackets.UI.MallPacket"/>.
    /// </summary>
    [PacketHeader("mall", Scope.InGame)]
    public class MallPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte State { get; set; }
    }
}
