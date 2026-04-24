//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Families
{
    /// <summary>
    /// Server-side family identifier sub-packet used by <see cref="GidxPacket"/>:
    /// <c>&lt;serverId&gt;.&lt;familyId&gt;</c>, e.g. <c>103.918</c>.
    /// When the character has no family the whole field collapses to <c>-1</c>
    /// on the wire, leaving <see cref="FamilyId"/> at its default value.
    /// </summary>
    public class GidxFamilySubPacket : PacketBase
    {
        [PacketIndex(0)]
        public int ServerId { get; set; }

        [PacketIndex(1)]
        public long FamilyId { get; set; }
    }
}
