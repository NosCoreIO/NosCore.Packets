//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Entities;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Packets.ServerPackets.Parcel;
using NosCore.Packets.ServerPackets.Visibility;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    // Lines taken from a packet trace of the live game.
    [TestClass]
    public class CapturedShapeTests
    {
        private static readonly Serializer Serializer = new(PacketCorpus.SerializableTypes.ToList());

        [TestMethod]
        public void TheStatusLineCarriesEachBuffAsItsCardAndLevel()
        {
            Assert.AreEqual("st 2 5922210 71 0 100 100 21450 1863 21450 1863 0 153.76",
                Serializer.Serialize(new StPacket
                {
                    Type = VisualType.Npc,
                    VisualId = 5922210,
                    Level = 71,
                    HpPercentage = 100,
                    MpPercentage = 100,
                    CurrentHp = 21450,
                    CurrentMp = 1863,
                    MaxHp = 21450,
                    MaxMp = 1863,
                    Buffs = [new PstBuffSubPacket { CardId = 153, Level = 76 }],
                }));
        }

        [TestMethod]
        public void TheWornEquipmentEndsWithTheMiniPet()
        {
            Assert.AreEqual("eq 14293841 0 0 2 100 2 337.769.267.159.225.802.4073.653.4310.-1.8910 -1 -1 100",
                Serializer.Serialize(new EqPacket
                {
                    VisualId = 14293841,
                    Gender = GenderType.Male,
                    HairStyle = HairStyleType.HairStyleC,
                    Haircolor = (HairColorType)100,
                    ClassType = CharacterClassType.Archer,
                    EqSubPacket = new InEquipmentSubPacket
                    {
                        Hat = 337, Armor = 769, MainWeapon = 267, SecondaryWeapon = 159, Mask = 225, Fairy = 802,
                        CostumeSuit = 4073, CostumeHat = 653, WeaponSkin = 4310, WingSkin = null, MiniPet = 8910,
                    },
                    Size = 100,
                }));
        }

        [TestMethod]
        [DataRow("ivn 2 27.2025.1.0", PocketType.Etc, (short)27, (short)2025, (short)1, (short)0, null)]
        [DataRow("ivn 6 0.904.0.0.0", PocketType.Specialist, (short)0, (short)904, (short)0, (short)0, (byte)0)]
        public void EachPocketWritesItsOwnNumberOfItemFields(string line, PocketType pocket, short slot, short vnum,
            short rareAmount, short? upgradeDesign, byte? secondUpgrade)
        {
            Assert.AreEqual(line, Serializer.Serialize(new IvnPacket
            {
                Type = pocket,
                IvnSubPackets =
                [
                    new IvnSubPacket
                    {
                        Slot = slot, VNum = vnum, RareAmount = rareAmount, UpgradeDesign = upgradeDesign,
                        SecondUpgrade = secondUpgrade, Unknown5 = null, Unknown6 = null,
                    },
                ],
            }));
        }

        [TestMethod]
        public void AMountWritesOnlyItsSlotVnumAndAmount()
        {
            Assert.AreEqual("inv 9 0.9149.1 1.13414.1",
                Serializer.Serialize(new InvPacket
                {
                    Type = PocketType.Mount,
                    IvnSubPackets =
                    [
                        new IvnSubPacket { Slot = 0, VNum = 9149, RareAmount = 1, UpgradeDesign = null, SecondUpgrade = null, Unknown5 = null, Unknown6 = null },
                        new IvnSubPacket { Slot = 1, VNum = 13414, RareAmount = 1, UpgradeDesign = null, SecondUpgrade = null, Unknown5 = null, Unknown6 = null },
                    ],
                }));
        }
    }
}
