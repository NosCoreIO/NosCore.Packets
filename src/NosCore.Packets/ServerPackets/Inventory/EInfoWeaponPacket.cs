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

        [PacketIndex(1)]
        public short ItemVNum { get; set; }

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

        [PacketIndex(14)]
        public short ShellEffectValue { get; set; } = -1;

        [PacketIndex(15)]
        public short ShellRarity { get; set; }

        [PacketIndex(16)]
        public long BoundCharacterId { get; set; }

        [PacketIndex(17)]
        public byte ShellOptionCount { get; set; }

        [PacketListIndex(18, IsOptional = true)]
        public List<EInfoShellOptionSubPacket>? ShellOptions { get; set; }

        // Out of 1000; the tooltip shows it as a percentage. Left null below +10, where the
        // client shows no gauge.
        [PacketIndex(19, IsOptional = true)]
        public short? PityGauge { get; set; }
    }
}
