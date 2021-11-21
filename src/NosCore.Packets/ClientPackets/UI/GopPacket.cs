//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.UI
{
    [PacketHeader("gop", Scope.InGame)]
    public class GopPacket : PacketBase
    {
        [PacketIndex(0)]
        public GopPacketType Option { get; set; }

        [PacketIndex(1)]
        public bool IsActive { get; set; }
    }
}