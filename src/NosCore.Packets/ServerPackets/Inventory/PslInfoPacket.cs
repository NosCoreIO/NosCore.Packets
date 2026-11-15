//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Mates;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for a partner specialist card. The point fields only show a line when above 0.
    [PacketHeader("pslinfo", Scope.InGame)]
    public class PslInfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public short ItemVNum { get; set; }

        [PacketIndex(1)]
        public ElementType Element { get; set; }

        [PacketIndex(2)]
        public short ElementRate { get; set; }

        [PacketIndex(3)]
        public byte LevelMinimum { get; set; }

        [PacketIndex(4)]
        public byte Speed { get; set; }

        [PacketIndex(5)]
        public short FireResistance { get; set; }

        [PacketIndex(6)]
        public short WaterResistance { get; set; }

        [PacketIndex(7)]
        public short LightResistance { get; set; }

        [PacketIndex(8)]
        public short DarkResistance { get; set; }

        [PacketIndex(9, SpecialSeparator = ".")]
        public ScnPacket.ScSkillDetails? Skill1 { get; set; }

        [PacketIndex(10, SpecialSeparator = ".")]
        public ScnPacket.ScSkillDetails? Skill2 { get; set; }

        [PacketIndex(11, SpecialSeparator = ".")]
        public ScnPacket.ScSkillDetails? Skill3 { get; set; }

        [PacketIndex(12)]
        public byte Upgrade { get; set; }

        // Shown as twenty times the value.
        [PacketIndex(13)]
        public short AttackPoints { get; set; }

        // Shown as ten times the value.
        [PacketIndex(14)]
        public short DefencePoints { get; set; }

        // Shown as a critical damage reduction percentage.
        [PacketIndex(15)]
        public short CriticalDamageReductionPoints { get; set; }

        // Shown as three hundred times the value.
        [PacketIndex(16)]
        public short HpMpPoints { get; set; }

        [PacketIndex(17)]
        public short FirePoints { get; set; }

        [PacketIndex(18)]
        public short WaterPoints { get; set; }

        [PacketIndex(19)]
        public short LightPoints { get; set; }

        [PacketIndex(20)]
        public short DarkPoints { get; set; }
    }
}
