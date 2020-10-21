//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("s_memo", Scope.InGame)]
    public class SMemoPacket : PacketBase
    {
        [PacketIndex(0)]
        public SMemoType Type { get; set; }

        [PacketIndex(1)]
        public string? Message { get; set; }
    }
}