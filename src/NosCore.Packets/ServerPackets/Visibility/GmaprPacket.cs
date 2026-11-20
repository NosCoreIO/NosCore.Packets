//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Visibility
{
    // Follows a player's in line.
    [PacketHeader("gmapr", Scope.InGame)]
    public class GmaprPacket : PacketBase
    {
        [PacketIndex(0)]
        public long VisualId { get; set; }

        [PacketIndex(1)]
        public byte Unknown1 { get; set; }
    }
}
