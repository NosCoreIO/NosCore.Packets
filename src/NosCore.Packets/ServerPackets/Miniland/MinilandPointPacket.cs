//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlpt", Scope.InGame)]
    public class MinilandPointPacket : PacketBase
    {
        [PacketIndex(0)]
        public long MinilandPoint { get; set; }

        [PacketIndex(0)]
        public byte Unknown { get; set; }
    }
}
