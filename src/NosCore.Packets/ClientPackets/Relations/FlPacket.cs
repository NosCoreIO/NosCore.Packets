//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Relations
{
    [PacketHeader("$fl", Scope.InGame | Scope.InExchange)]
    public class FlPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}