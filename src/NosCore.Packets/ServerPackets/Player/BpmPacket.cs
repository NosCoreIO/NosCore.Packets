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
    /// Server-side compact battle-pass marker, observed as <c>bpm 0 0 0</c>
    /// (three bytes). Distinct from the large
    /// <see cref="NosCore.Packets.ClientPackets.Player.BpmPacket"/> request that
    /// carries the full quest list.
    /// </summary>
    [PacketHeader("bpm", Scope.InGame)]
    public class BpmPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte State { get; set; }

        [PacketIndex(1)]
        public byte Unknown1 { get; set; }

        [PacketIndex(2)]
        public byte Unknown2 { get; set; }
    }
}
