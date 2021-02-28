//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Login
{
    public class WorldCharacterCount : PacketBase
    {
        [PacketIndex(0)] 
        public int WorldId { get; set; } = -99;

        [PacketIndex(1)]
        public byte CharacterCount { get; set; }
    }
}