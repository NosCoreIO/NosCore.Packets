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
    // Plays a ground-targeted skill at a map cell; each entity it hits still gets its own su.
    [PacketHeader("bs", Scope.InGame)]
    public class BsPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public short MapX { get; set; }

        [PacketIndex(3)]
        public short MapY { get; set; }

        [PacketIndex(4)]
        public long SkillVnum { get; set; }

        [PacketIndex(5)]
        public long SkillCooldown { get; set; }

        [PacketIndex(6)]
        public long AttackAnimation { get; set; }

        [PacketIndex(7)]
        public long SkillEffect { get; set; }

        [PacketIndex(8)]
        public byte Unknown1 { get; set; }

        [PacketIndex(9)]
        public byte Unknown2 { get; set; }

        [PacketIndex(10)]
        public byte Unknown3 { get; set; } = 1;

        [PacketIndex(11)]
        public byte Unknown4 { get; set; } = 1;

        [PacketIndex(12)]
        public byte Unknown5 { get; set; }

        [PacketIndex(13)]
        public byte Unknown6 { get; set; }

        [PacketIndex(14)]
        public byte Unknown7 { get; set; }
    }
}
