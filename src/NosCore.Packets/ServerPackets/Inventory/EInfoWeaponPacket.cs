//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for a main or secondary weapon.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoWeaponPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.WeaponDefault;

        public short ItemVNum { get; set; }

        public bool IsLimited { get; set; }

        [PacketIndex(1)]
        public short WireItemVNum
        {
            get => LimitedItem.ToWire(ItemVNum, IsLimited);
            set
            {
                ItemVNum = LimitedItem.VNum(value);
                IsLimited = LimitedItem.IsLimited(value);
            }
        }

        [PacketIndex(2)]
        public short Rare { get; set; }

        [PacketIndex(3)]
        public byte Upgrade { get; set; }

        [PacketIndex(4)]
        public bool IsFixed { get; set; }

        [PacketIndex(5)]
        public byte LevelMinimum { get; set; }

        [PacketIndex(6)]
        public short DamageMinimum { get; set; }

        [PacketIndex(7)]
        public short DamageMaximum { get; set; }

        [PacketIndex(8)]
        public short HitRate { get; set; }

        [PacketIndex(9)]
        public short CriticalLuckRate { get; set; }

        [PacketIndex(10)]
        public short CriticalRate { get; set; }

        [PacketIndex(11)]
        public byte Ammo { get; set; }

        [PacketIndex(12)]
        public byte MaximumAmmo { get; set; }

        [PacketIndex(13)]
        public long Price { get; set; }

        // -1, but for a partner weapon's line that carries a weapon's vnum there.
        [PacketIndex(14)]
        public short Unknown { get; set; } = -1;

        [PacketIndex(15)]
        public short ShellRarity { get; set; }

        [PacketIndex(16)]
        public long BoundCharacterId { get; set; }

        [PacketIndex(17)]
        public byte ShellOptionCount { get; set; }

        // A non-zero value v adds a "Current Shell Level (v % 10/v / 10)" line. It is 62 or 81 to 88 on most traced
        // items with options, 0 on others, and negative on a few bound ones, which is not settled.
        [PacketIndex(18)]
        public short ShellLevel { get; set; }

        [PacketListIndex(19, IsOptional = true)]
        public List<EInfoShellOptionSubPacket>? ShellOptions { get; set; }

        // The rune section is only on the line of an item with runes.
        [PacketIndex(20, IsOptional = true)]
        public byte? RuneUpgrade { get; set; }

        // 0, or 1 on a few items with runes.
        [PacketIndex(21, IsOptional = true)]
        public byte? Unknown2 { get; set; }

        [PacketIndex(22, IsOptional = true)]
        public byte? RuneCount { get; set; }

        [PacketListIndex(23, IsOptional = true)]
        public List<EInfoRuneSubPacket>? Runes { get; set; }

        // Out of 1000, drawn as the pity gauge bar in the window's top corner; 0 draws none.
        [PacketIndex(24)]
        public short PityGauge { get; set; }
    }
}
