//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("s_memoi2")]
    public class SMemoi2Packet : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public SMemoType Type { get; set; }

        [PacketIndex(1)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(2)]
        public short FirstArgument { get; set; }

        [PacketIndex(3)]
        public string? SecondArgument { get; set; }

        [PacketIndex(4)]
        public string ThirdArgument { get; set; } = "";

        [PacketIndex(5)]
        public short FourthArgument { get; set; }
    }
}