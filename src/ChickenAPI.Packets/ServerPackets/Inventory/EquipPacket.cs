using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Inventory
{
    [PacketHeader("equip")]
    public class EquipPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = "")]
        public UpgradeRareSubPacket WeaponUpgradeRareSubPacket { get; set; }

        [PacketIndex(1, SpecialSeparator = "")]
        public UpgradeRareSubPacket ArmorUpgradeRareSubPacket { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public EquipmentSubPacket MainWeapon { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public EquipmentSubPacket Armor { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public EquipmentSubPacket Hat { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public EquipmentSubPacket Gloves { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public EquipmentSubPacket Boots { get; set; }

        [PacketIndex(7, IsOptional = true)]
        public EquipmentSubPacket SecondaryWeapon { get; set; }

        [PacketIndex(8, IsOptional = true)]
        public EquipmentSubPacket Necklace { get; set; }

        [PacketIndex(9, IsOptional = true)]
        public EquipmentSubPacket Ring { get; set; }

        [PacketIndex(10, IsOptional = true)]
        public EquipmentSubPacket Bracelet { get; set; }

        [PacketIndex(11, IsOptional = true)]
        public EquipmentSubPacket Mask { get; set; }

        [PacketIndex(12, IsOptional = true)]
        public EquipmentSubPacket Fairy { get; set; }

        [PacketIndex(13, IsOptional = true)]
        public EquipmentSubPacket Amulet { get; set; }

        [PacketIndex(14, IsOptional = true)]
        public EquipmentSubPacket Sp { get; set; }

        [PacketIndex(15, IsOptional = true)]
        public EquipmentSubPacket CostumeSuit { get; set; }

        [PacketIndex(16, IsOptional = true)]
        public EquipmentSubPacket CostumeHat { get; set; }

        [PacketIndex(17, IsOptional = true)]
        public EquipmentSubPacket WeaponSkin { get; set; }
    }
}