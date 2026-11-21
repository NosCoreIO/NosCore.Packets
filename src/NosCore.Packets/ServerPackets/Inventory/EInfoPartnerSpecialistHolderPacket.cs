//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    // Answer to eqinfo for a partner specialist card holder. Everything after IsFull is the held card's, in the
    // order of its pslinfo, and only sent when it holds one.
    [PacketHeader("e_info", Scope.InGame, AllowDuplicateHeader = true)]
    public class EInfoPartnerSpecialistHolderPacket : PacketBase
    {
        [PacketIndex(0)]
        public EInfoPacketType Type { get; set; } = EInfoPacketType.PartnerSpecialistHolder;

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
        public bool IsFull { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public short? HoldingVNum { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public ElementType? Element { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public short? Skill1VNum { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public byte? Skill1Rank { get; set; }

        [PacketIndex(7, IsOptional = true)]
        public short? Skill2VNum { get; set; }

        [PacketIndex(8, IsOptional = true)]
        public byte? Skill2Rank { get; set; }

        [PacketIndex(9, IsOptional = true)]
        public short? Skill3VNum { get; set; }

        [PacketIndex(10, IsOptional = true)]
        public byte? Skill3Rank { get; set; }

        [PacketIndex(11, IsOptional = true)]
        public byte? Upgrade { get; set; }

        [PacketIndex(12, IsOptional = true)]
        public short? AttackPoints { get; set; }

        [PacketIndex(13, IsOptional = true)]
        public short? DefencePoints { get; set; }

        [PacketIndex(14, IsOptional = true)]
        public short? CriticalDamageReductionPoints { get; set; }

        [PacketIndex(15, IsOptional = true)]
        public short? HpMpPoints { get; set; }

        [PacketIndex(16, IsOptional = true)]
        public short? FirePoints { get; set; }

        [PacketIndex(17, IsOptional = true)]
        public short? WaterPoints { get; set; }

        [PacketIndex(18, IsOptional = true)]
        public short? LightPoints { get; set; }

        [PacketIndex(19, IsOptional = true)]
        public short? DarkPoints { get; set; }
    }
}
