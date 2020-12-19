//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Visibility
{
    public class InCharacterSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public AuthorityType Authority { get; set; }

        [PacketIndex(1)]
        public GenderType Gender { get; set; }

        [PacketIndex(2)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(3)]
        public HairColorType HairColor { get; set; }

        [PacketIndex(4)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(5, SpecialSeparator = ".")]
        public InEquipmentSubPacket? Equipment { get; set; }

        [PacketIndex(6, SpecialSeparator = " ")]
        public InAliveSubPacket? InAliveSubPacket { get; set; }

        [PacketIndex(7)]
        public bool IsSitting { get; set; }

        [PacketIndex(8)]
        public long? GroupId { get; set; }

        [PacketIndex(9)]
        public byte Fairy { get; set; }

        [PacketIndex(10)]
        public byte FairyElement { get; set; }

        [PacketIndex(11)]
        public byte Unknown { get; set; } //TODO to find

        [PacketIndex(12)]
        public byte Morph { get; set; }

        //TODO: Find what GroupId & 3 are made for
        [PacketIndex(13)]
        public byte Unknown2 { get; set; }

        [PacketIndex(14)]
        public byte Unknown3 { get; set; }

        [PacketIndex(15, SpecialSeparator = "")]
        public UpgradeRareSubPacket? WeaponUpgradeRareSubPacket { get; set; }

        [PacketIndex(16, SpecialSeparator = "")]
        public UpgradeRareSubPacket? ArmorUpgradeRareSubPacket { get; set; }

        [PacketIndex(17, SpecialSeparator = ".")]
        public FamilySubPacket? FamilySubPacket { get; set; }

        [PacketIndex(18)]
        public string? FamilyName { get; set; }

        [PacketIndex(19)]
        public short ReputIco { get; set; }

        [PacketIndex(20)]
        public bool Invisible { get; set; }

        [PacketIndex(21)]
        public byte MorphUpgrade { get; set; }

        [PacketIndex(22)]
        public FactionType Faction { get; set; }

        [PacketIndex(23)]
        public byte MorphUpgrade2 { get; set; }

        [PacketIndex(24)]
        public byte Level { get; set; }

        [PacketIndex(25)]
        public byte FamilyLevel { get; set; }

        [PacketListIndex(26, ListSeparator = "|")]
        public List<bool>? FamilyIcons { get; set; }

        [PacketIndex(27)]
        public bool ArenaWinner { get; set; }

        [PacketIndex(28)]
        public short Compliment { get; set; }

        [PacketIndex(29)]
        public byte Size { get; set; }

        [PacketIndex(30)]
        public byte HeroLevel { get; set; }

        [PacketIndex(31)]
        public short Title { get; set; }
    }
}