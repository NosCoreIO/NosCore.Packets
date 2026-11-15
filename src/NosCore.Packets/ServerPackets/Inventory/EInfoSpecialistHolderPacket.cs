//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for a card holder. Everything after IsFull is only sent when it holds a card.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoSpecialistHolderPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.SpecialistHolder;

        [PacketIndex(1)]
        public short ItemVNum { get; set; }

        [PacketIndex(2)]
        public bool IsFull { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? HoldingVNum { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public byte? SpLevel { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public long? Xp { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public long? XpMaximum { get; set; }

        [PacketIndex(7, IsOptional = true)]
        public byte? Upgrade { get; set; }

        [PacketIndex(8, IsOptional = true)]
        public int? SlHit { get; set; }

        [PacketIndex(9, IsOptional = true)]
        public int? SlDefence { get; set; }

        [PacketIndex(10, IsOptional = true)]
        public int? SlElement { get; set; }

        [PacketIndex(11, IsOptional = true)]
        public int? SlHp { get; set; }

        [PacketIndex(12, IsOptional = true)]
        public int? FreePoints { get; set; }

        [PacketIndex(13, IsOptional = true)]
        public short? SpStoneUpgrade { get; set; }

        [PacketIndex(14, IsOptional = true)]
        public short? FireResistance { get; set; }

        [PacketIndex(15, IsOptional = true)]
        public short? WaterResistance { get; set; }

        [PacketIndex(16, IsOptional = true)]
        public short? LightResistance { get; set; }

        [PacketIndex(17, IsOptional = true)]
        public short? DarkResistance { get; set; }

        [PacketIndex(18, IsOptional = true)]
        public short? AttackPoints { get; set; }

        [PacketIndex(19, IsOptional = true)]
        public short? DefencePoints { get; set; }

        [PacketIndex(20, IsOptional = true)]
        public short? ElementPoints { get; set; }

        [PacketIndex(21, IsOptional = true)]
        public short? HpMpPoints { get; set; }

        [PacketIndex(22, IsOptional = true)]
        public short? FirePoints { get; set; }

        [PacketIndex(23, IsOptional = true)]
        public short? WaterPoints { get; set; }

        [PacketIndex(24, IsOptional = true)]
        public short? LightPoints { get; set; }

        [PacketIndex(25, IsOptional = true)]
        public short? DarkPoints { get; set; }
    }
}
