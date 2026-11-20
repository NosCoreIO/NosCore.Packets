//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("rstart", Scope.InGame)]
    public class RStartPacket : PacketBase
    {
        // The dialog's No button sends the header alone.
        [PacketIndex(0, IsOptional = true)]
        public RStartPacketType? Type { get; set; }
    }
}
