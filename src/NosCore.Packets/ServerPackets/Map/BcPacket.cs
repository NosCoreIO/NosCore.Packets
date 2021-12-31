//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Map
{
    [PacketHeader("bc", Scope.InGame)]
    public class BcPacket : PacketBase
    {
        [PacketIndex(0)]
        public short FirstArgument { get; set; }

        [PacketIndex(1)]
        public short SecondArgument { get; set; }

        [PacketIndex(2)]
        public short ThirdArgument { get; set; }
    }
}
