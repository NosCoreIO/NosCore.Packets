//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // The fighting position (1 to 3) the receiver ended up with.
    [PacketHeader("ta_pn", Scope.InGame)]
    public class TaPnPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Position { get; set; }
    }
}
