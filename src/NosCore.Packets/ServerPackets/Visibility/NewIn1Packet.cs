//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;
using NosCore.Packets.ServerPackets.Inventory;
using System.Collections.Generic;

namespace NosCore.Packets.ServerPackets.Visibility
{
    [PacketHeader("in")]
    public class NewIn1Packet : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; } // 1

        [PacketIndex(1)]
        public string? Name { get; set; }

        [PacketIndex(2)]
        public string? EmptyString { get; set; }

        [PacketIndex(3)]
        public long VisualId { get; set; }

        [PacketIndex(4)]
        public short PositionX { get; set; }

        [PacketIndex(5)]
        public short PositionY { get; set; }

        [PacketIndex(6)]
        public byte Direction { get; set; }

        [PacketIndex(7)]
        public AuthorityUIType Authority { get; set; }

        [PacketIndex(8)]
        public GenderType Gender { get; set; }

        [PacketIndex(9)]
        public HairStyleType HairStyle { get; set; }

        [PacketIndex(10)]
        public HairColorType HairColor { get; set; }

        [PacketIndex(11)]
        public CharacterClassType Class { get; set; }

        [PacketIndex(12, SpecialSeparator = ".")]
        public InEquipmentSubPacket? Equipment { get; set; }

        [PacketIndex(13)]
        public int Hp { get; set; } //min 0 max 100 (this is % of HP)

        [PacketIndex(14)]
        public int Mp { get; set; } //min 0 max 100 (read above)

        [PacketIndex(15)]
        public bool IsSitting { get; set; }

        [PacketIndex(16)]
        public long? GroupId { get; set; }

        [PacketIndex(17)]
        public byte Fairy { get; set; } // change Fairy Movement

        [PacketIndex(18)]
        public byte FairyElement { get; set; }

        [PacketIndex(19)]
        public byte Unknown { get; set; } //TODO to find const 0 propably unused

        [PacketIndex(20)]
        public byte FairyMorph { get; set; }

        [PacketIndex(21)]
        public byte TeleportEffect { get; set; } // 0-pentagram 1-nothing 2-jump from sky

        [PacketIndex(22)]
        public int Morph { get; set; }

        [PacketIndex(23, SpecialSeparator = "")]
        public UpgradeRareSubPacket? WeaponUpgradeRareSubPacket { get; set; }

        [PacketIndex(24, SpecialSeparator = "")]
        public UpgradeRareSubPacket? ArmorUpgradeRareSubPacket { get; set; }

        [PacketIndex(25, SpecialSeparator = ".")]
        public InFamily Family { get; set; } //1.916 (famid:1 title before nickname:916) 916 is used to show rank in family (but all titles can be showed)

        [PacketIndex(26)]
        public string? FamilyName { get; set; }

        [PacketIndex(27)]
        public short ReputIco { get; set; }

        [PacketIndex(28)]
        public bool Invisible { get; set; }

        [PacketIndex(29)]
        public byte MorphUpgrade { get; set; }

        [PacketIndex(30)]
        public FactionType FactionType { get; set; }

        [PacketIndex(31)]
        public byte MorphUpgrade2 { get; set; }

        [PacketIndex(32)]
        public byte Level { get; set; }

        [PacketIndex(33)]
        public byte FamilyLevel { get; set; }

        [PacketListIndex(34, ListSeparator = "|")]
        public List<bool>? FamilyIcons { get; set; }

        [PacketIndex(35)]
        public bool ArenaWinner { get; set; }

        [PacketIndex(36)]
        public short Compliment { get; set; }

        [PacketIndex(37)]
        public byte Size { get; set; }

        [PacketIndex(38)]
        public byte HeroLevel { get; set; }

        [PacketIndex(39)]
        public int Title { get; set; }
    }
}