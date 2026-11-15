//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Families
{
    [PacketHeader("glist", Scope.InGame | Scope.InTrade)]
    public class GListPacket : PacketBase
    {
        // Always 0 from the client.
        [PacketIndex(0)]
        public byte Unknown { get; set; }

        [PacketIndex(1)]
        public GListPacketType Type { get; set; }
    }
}