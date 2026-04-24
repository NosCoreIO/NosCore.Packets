//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.TimeSpaces
{
    public class MinfoConversationSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Had { get; set; }

        [PacketIndex(1, SpecialSeparator = "/")]
        public int Total { get; set; }
    }
}
