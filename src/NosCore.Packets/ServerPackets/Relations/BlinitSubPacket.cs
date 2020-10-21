//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Relations
{
    public class BlinitSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public long RelatedCharacterId { get; set; }

        [PacketIndex(1)]
        public string? CharacterName { get; set; }
    }
}