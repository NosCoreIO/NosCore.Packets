//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    /// <summary>
    /// Server-side compact packet observed as <c>rc 1 14477871 11468 0</c>.
    /// Fields are unnamed until the semantics are reverse-engineered.
    /// </summary>
    [PacketHeader("rc", Scope.InGame)]
    public class RcPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int Unknown1 { get; set; }

        [PacketIndex(3)]
        public int Unknown2 { get; set; }
    }
}
