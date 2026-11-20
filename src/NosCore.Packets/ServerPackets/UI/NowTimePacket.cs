//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    // The server's clock, sent on entering the game.
    [PacketHeader("nowtime", Scope.InGame)]
    public class NowTimePacket : PacketBase
    {
        [PacketIndex(0)]
        public string ExtraSpace { get; set; } = string.Empty;

        [PacketIndex(1)]
        public byte Hour { get; set; }

        [PacketIndex(2)]
        public byte Minute { get; set; }

        [PacketIndex(3)]
        public byte Second { get; set; }
    }
}
