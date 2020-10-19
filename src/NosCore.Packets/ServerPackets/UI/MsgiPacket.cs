//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("msgi")]
    public class MsgiPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public MessageType Type { get; set; }

        [PacketIndex(1)]
        public Game18NConstString Message { get; set; }

        [PacketIndex(2)]
        public short FirstArgument { get; set; }

        [PacketIndex(3)]
        public short SecondArgument { get; set; }

        [PacketIndex(4)]
        public short ThirdArgument { get; set; }

        [PacketIndex(5)]
        public short FourthArgument { get; set; }

        [PacketIndex(6)]
        public short FifthArgument { get; set; }
    }
}