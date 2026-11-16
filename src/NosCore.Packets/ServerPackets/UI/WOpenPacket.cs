//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("wopen", Scope.InGame)]
    public class WopenPacket : PacketBase
    {
        [PacketIndex(0)]
        public WindowType Type { get; set; }

        [PacketIndex(1)]
        public byte Argument { get; set; }

        [PacketIndex(2)]
        public byte Argument2 { get; set; }
    }
}