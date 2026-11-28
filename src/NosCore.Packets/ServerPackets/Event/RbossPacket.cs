//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // A raid boss's HP bar. Sent right after the boss comes into view and about once a second while it
    // lives, the last time with no HP left.
    [PacketHeader("rboss", Scope.InGame)]
    public class RbossPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public int CurrentHp { get; set; }

        [PacketIndex(3)]
        public int MaxHp { get; set; }

        [PacketIndex(4)]
        public short VNum { get; set; }

        // 0 in every trace.
        [PacketIndex(5)]
        public byte Unknown { get; set; }
    }
}
