//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Event
{
    [PacketHeader("rl", Scope.InGame)]
    public class RlPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Type { get; set; }

        [PacketIndex(1)]
        public string? CharacterName { get; set; }
    }
}