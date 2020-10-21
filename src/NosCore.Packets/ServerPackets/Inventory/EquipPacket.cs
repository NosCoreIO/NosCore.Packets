//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Inventory
{
    [PacketHeader("equip", Scope.InGame)]
    public class EquipPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = "")]
        public UpgradeRareSubPacket? WeaponUpgradeRareSubPacket { get; set; }

        [PacketIndex(1, SpecialSeparator = "")]
        public UpgradeRareSubPacket? ArmorUpgradeRareSubPacket { get; set; }

        [PacketIndex(2, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? MainWeapon { get; set; }

        [PacketIndex(3, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Armor { get; set; }

        [PacketIndex(4, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Hat { get; set; }

        [PacketIndex(5, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Gloves { get; set; }

        [PacketIndex(6, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Boots { get; set; }

        [PacketIndex(7, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? SecondaryWeapon { get; set; }

        [PacketIndex(8, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Necklace { get; set; }

        [PacketIndex(9, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Ring { get; set; }

        [PacketIndex(10, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Bracelet { get; set; }

        [PacketIndex(11, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Mask { get; set; }

        [PacketIndex(12, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Fairy { get; set; }

        [PacketIndex(13, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Amulet { get; set; }

        [PacketIndex(14, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? Sp { get; set; }

        [PacketIndex(15, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? CostumeSuit { get; set; }

        [PacketIndex(16, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? CostumeHat { get; set; }

        [PacketIndex(17, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? WeaponSkin { get; set; }

        [PacketIndex(18, IsOptional = true, SpecialSeparator = ".")]
        public EquipmentSubPacket? WingSkin { get; set; }
    }
}
