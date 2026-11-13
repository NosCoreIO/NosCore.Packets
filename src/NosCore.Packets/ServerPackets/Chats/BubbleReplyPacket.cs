//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Chats
{
    // Puts the bubble over the receiver's own character for 30 minutes; the client then announces it with a csp.
    [PacketHeader("csp_r", Scope.InGame)]
    public class BubbleReplyPacket : PacketBase
    {
        [PacketIndex(0, EscapeSpaces = true, SpaceEscape = "\v")]
        public string? Message { get; set; }
    }
}
