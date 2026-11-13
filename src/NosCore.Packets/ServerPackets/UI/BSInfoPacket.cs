//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    // Battle search window. Time is the countdown in seconds, -1 for none.
    [PacketHeader("bsinfo", Scope.InGame)]
    public class BSInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public BsInfoMode Mode { get; set; }

        [PacketIndex(1)]
        public BscPacketType Title { get; set; }

        [PacketIndex(2)]
        public short Time { get; set; }

        [PacketIndex(3)]
        public BsInfoText Text { get; set; }
    }
}
