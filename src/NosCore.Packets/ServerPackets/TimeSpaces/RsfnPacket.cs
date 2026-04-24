//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.TimeSpaces
{
    [PacketHeader("rsfn", Scope.InGame)]
    public class RsfnPacket : PacketBase
    {
        [PacketIndex(0)]
        public int MapIndexX { get; set; }

        [PacketIndex(1)]
        public int MapIndexY { get; set; }

        [PacketIndex(2)]
        public int Status { get; set; }
    }
}
