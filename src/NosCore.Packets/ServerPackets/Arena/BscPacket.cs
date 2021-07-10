//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    [PacketHeader("bsc", Scope.InGame)]
    public class BscPacket : PacketBase
    {
        [PacketIndex(0)]
        public BscPacketType Type { get; set; }

        [PacketIndex(1)]
        public byte? Option { get; set; }
    }
}
