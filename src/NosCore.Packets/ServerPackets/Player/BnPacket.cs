//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    // One line of the notice board the client shows on entering the game.
    [PacketHeader("bn", Scope.InGame)]
    public class BnPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte BnNumber { get; set; }

        [PacketIndex(1, EscapeSpaces = true)]
        public string? Message { get; set; }
    }
}