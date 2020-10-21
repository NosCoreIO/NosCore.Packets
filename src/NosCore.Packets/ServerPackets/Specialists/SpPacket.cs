//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Specialists
{
    [PacketHeader("sp", Scope.InGame)]
    public class SpPacket : PacketBase
    {
        [PacketIndex(0)]
        public int AdditionalPoint { get; set; }

        [PacketIndex(1)]
        public int MaxAdditionalPoint { get; set; }

        [PacketIndex(2)]
        public int SpPoint { get; set; }

        [PacketIndex(3)]
        public int MaxSpPoint { get; set; }
    }
}