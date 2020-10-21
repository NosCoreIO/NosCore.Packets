//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("tit", Scope.InGame)]
    public class TitPacket : PacketBase
    {
        [PacketIndex(0)]
        public Game18NConstString ClassType { get; set; }

        [PacketIndex(1)]
        public string? Name { get; set; }
    }
}