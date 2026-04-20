//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // e_info subtype 10 — response the server emits when a client sends
    // req_info 5 (NPC monster) or req_info 6 (mate). OpenNos builds the
    // same 26-field layout from NpcMonster.GenerateEInfo / Mate.GenerateEInfo,
    // so we share a single packet class. Field order and types match the
    // OpenNos format string verbatim — reordering will break the client tooltip.
    [PacketHeader("e_info", Scope.InGame)]
    public class EInfoNpcMonsterPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte SubType { get; set; } = 10;

        [PacketIndex(1)]
        public short NpcMonsterVNum { get; set; }

        [PacketIndex(2)]
        public byte Level { get; set; }

        [PacketIndex(3)]
        public byte Element { get; set; }

        [PacketIndex(4)]
        public byte AttackClass { get; set; }

        [PacketIndex(5)]
        public short ElementRate { get; set; }

        [PacketIndex(6)]
        public byte AttackUpgrade { get; set; }

        [PacketIndex(7)]
        public short DamageMinimum { get; set; }

        [PacketIndex(8)]
        public short DamageMaximum { get; set; }

        [PacketIndex(9)]
        public short Concentrate { get; set; }

        [PacketIndex(10)]
        public byte CriticalChance { get; set; }

        [PacketIndex(11)]
        public short CriticalRate { get; set; }

        [PacketIndex(12)]
        public byte DefenceUpgrade { get; set; }

        [PacketIndex(13)]
        public short CloseDefence { get; set; }

        [PacketIndex(14)]
        public short DefenceDodge { get; set; }

        [PacketIndex(15)]
        public short DistanceDefence { get; set; }

        [PacketIndex(16)]
        public short DistanceDefenceDodge { get; set; }

        [PacketIndex(17)]
        public short MagicDefence { get; set; }

        [PacketIndex(18)]
        public short FireResistance { get; set; }

        [PacketIndex(19)]
        public short WaterResistance { get; set; }

        [PacketIndex(20)]
        public short LightResistance { get; set; }

        [PacketIndex(21)]
        public short DarkResistance { get; set; }

        [PacketIndex(22)]
        public int MaxHp { get; set; }

        [PacketIndex(23)]
        public int MaxMp { get; set; }

        [PacketIndex(24)]
        public int Unknown { get; set; } = -1;

        [PacketIndex(25)]
        public string? Name { get; set; }
    }
}
