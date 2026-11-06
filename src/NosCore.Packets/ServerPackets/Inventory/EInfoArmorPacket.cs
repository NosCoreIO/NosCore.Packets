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
    // Answer to eqinfo for an armour.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoArmorPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.Armor;

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
        public short CloseDefence { get; set; }

        [PacketIndex(7)]
        public short DistanceDefence { get; set; }

        [PacketIndex(8)]
        public short MagicDefence { get; set; }

        [PacketIndex(9)]
        public short DefenceDodge { get; set; }

        [PacketIndex(10)]
        public long Price { get; set; }

        [PacketIndex(11)]
        public short ShellEffectValue { get; set; } = -1;

        [PacketIndex(12)]
        public short ShellRarity { get; set; }

        [PacketIndex(13)]
        public long BoundCharacterId { get; set; }

        [PacketIndex(14)]
        public byte ShellOptionCount { get; set; }

        [PacketListIndex(15, IsOptional = true)]
        public List<EInfoShellOptionSubPacket>? ShellOptions { get; set; }

        // Required after the options. Despite its name it is not the bar: a non-zero value v adds a
        // "Current Shell Level (v % 10/v / 10)" line.
        [PacketIndex(16)]
        public short Gauge { get; set; }

        // Out of 1000, drawn as the pity gauge bar in the window's top corner; 0 draws none.
        [PacketIndex(17)]
        public short PityGauge { get; set; }
    }
}
