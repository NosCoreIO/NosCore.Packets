//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Chat
{
    [PacketHeader("btk", Scope.InGame | Scope.InTrade | Scope.WhileDead)]
    [MinimumInterval(Milliseconds = 500)]
    public class BtkPacket : PacketBase
    {
        [PacketIndex(0)]
        public long CharacterId { get; set; }

        // The client writes the friend's name before the message.
        [PacketIndex(1)]
        public string? CharacterName { get; set; }

        [PacketIndex(2)]
        public string? Message { get; set; }
    }
}