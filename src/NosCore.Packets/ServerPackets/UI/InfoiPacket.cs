//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("infoi")]
    public class InfoiPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(1)]
        public short FirstArgument { get; set; }

        [PacketIndex(2)]
        public short SecondArgument { get; set; }

        [PacketIndex(3)]
        public short ThirdArgument { get; set; }
    }
}