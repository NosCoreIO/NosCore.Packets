//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Map
{
    [PacketHeader("bgm2", Scope.InGame)]
    public class Bgm2Packet : PacketBase
    {
        [PacketIndex(0)]
        public short MusicId { get; set; }
    }
}
