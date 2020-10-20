//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Visibility
{
    public class InEquipmentSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short? Hat { get; set; }

        [PacketIndex(1)]
        public short? Armor { get; set; }

        [PacketIndex(2)]
        public short? MainWeapon { get; set; }

        [PacketIndex(3)]
        public short? SecondaryWeapon { get; set; }

        [PacketIndex(4)]
        public short? Mask { get; set; }

        [PacketIndex(5)]
        public short? Fairy { get; set; }

        [PacketIndex(6)]
        public short? CostumeSuit { get; set; }

        [PacketIndex(7)]
        public short? CostumeHat { get; set; }

        [PacketIndex(8)]
        public short? WeaponSkin { get; set; }

        [PacketIndex(9)]
        public short? WingSkin { get; set; }
    }
}