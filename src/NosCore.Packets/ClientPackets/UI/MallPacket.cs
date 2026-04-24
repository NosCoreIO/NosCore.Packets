//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.UI
{
    [PacketHeader("mall", Scope.InGame)]
    public class MallPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte State { get; set; }
    }
}
