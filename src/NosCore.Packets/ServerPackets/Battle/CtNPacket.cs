//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Battle
{
    // Starts the cast of a skill aimed at a map cell, the ground counterpart of ct; the cell
    // itself follows in bs when the skill lands. The client looks the target pair up and then
    // ignores it, so a cell cast carries -1 as its id.
    [PacketHeader("ct_n", Scope.InGame)]
    public class CtNPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public VisualType TargetVisualType { get; set; }

        [PacketIndex(3)]
        public long TargetId { get; set; } = -1;

        [PacketIndex(4)]
        public short CastAnimationId { get; set; } = -1;

        [PacketIndex(5)]
        public short CastEffect { get; set; } = -1;

        [PacketIndex(6)]
        public long SkillId { get; set; }
    }
}
