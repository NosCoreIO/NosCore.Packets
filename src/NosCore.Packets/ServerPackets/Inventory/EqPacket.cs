//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Visibility;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Inventory
{
    [PacketHeader("eq", Scope.InGame)]
    public class EqPacket : PacketBase
    {
        [PacketIndex(0)]
        public long VisualId { get; set; }

        [PacketIndex(1)]
        public byte Visibility { get; set; }

        [PacketIndex(2)]
        public GenderType Gender { get; set; }

        [PacketIndex(3)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(4)]
        public HairColorType Haircolor { get; set; }

        [PacketIndex(5)]
        public CharacterClassType ClassType { get; set; }

        [PacketIndex(6, SpecialSeparator = ".")]
        public InEquipmentSubPacket? EqSubPacket { get; set; }

        [PacketIndex(7, SpecialSeparator = "")]
        public UpgradeRareSubPacket? WeaponUpgradeRarePacket { get; set; }

        [PacketIndex(8, SpecialSeparator = "")]
        public UpgradeRareSubPacket? ArmorUpgradeRarePacket { get; set; }

        [PacketIndex(9)]
        public byte Size { get; set; }
    }
}