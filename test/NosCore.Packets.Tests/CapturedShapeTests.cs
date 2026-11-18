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
using NosCore.Packets.ServerPackets.Player;
using NosCore.Packets.ServerPackets.TimeSpaces;
using NosCore.Packets.ServerPackets.Visibility;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    // Lines taken from a packet trace of the live game.
    [TestClass]
    public class CapturedShapeTests
    {
        private static readonly Serializer Serializer = new(PacketCorpus.SerializableTypes.ToList());

        private static readonly Deserializer Deserializer =
            new(new[] { typeof(IvnPacket), typeof(InvPacket), typeof(IvnSubPacket) });

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
    
        [TestMethod]
        [DataRow("ivn 2 27.2025.1.0")]
        [DataRow("ivn 6 0.904.0.0.0")]
        public void AShortPocketItemReadsBackAsWritten(string line)
        {
            Assert.AreEqual(line, Serializer.Serialize(Deserializer.Deserialize(line)));
        }

        [TestMethod]
        public void AMountReadsBackWithoutTheMissingFields()
        {
            var packet = (InvPacket)Deserializer.Deserialize("inv 9 0.9149.1 1.13414.1");

            Assert.IsNull(packet.IvnSubPackets![1]!.UpgradeDesign);
            Assert.AreEqual("inv 9 0.9149.1 1.13414.1", Serializer.Serialize(packet));
        }

        [TestMethod]
        public void TheRoomMapCarriesItsGridSize()
        {
            Assert.AreEqual("rsfm 14 0 6 12 0",
                Serializer.Serialize(new RsfmPacket { Unknown = 14, Type = RsfmPacketType.Open, Width = 6, Height = 12 }));
        }

        [TestMethod]
        public void EachWornItemCarriesSevenFields()
        {
            Assert.AreEqual("equip 1 2 0.267.1.0.0.0.0",
                Serializer.Serialize(new EquipPacket
                {
                    WeaponUpgradeRareSubPacket = new UpgradeRareSubPacket { Rare = 1 },
                    ArmorUpgradeRareSubPacket = new UpgradeRareSubPacket { Rare = 2 },
                    MainWeapon = new EquipmentSubPacket { EquipmentType = EquipmentType.MainWeapon, VNum = 267, Rare = 1 },
                }));
        }

        [TestMethod]
        public void APlayerLineWithANegativeRareReadsBack()
        {
            const string line = "in 1 Alice - 1234 38 72 2 0 0 1 96 1 200.165.141.70.372.280.624.4164.-1.-1.-1 100 100 0 -1 4 3 0 7 0 0 3 -2 100.918 Family 23 0 0 0 0 81 10 0|0|2 0 0 100 0 9337";
            var deserializer = new Deserializer(PacketCorpus.SerializableTypes.Where(t => t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Visibility") || t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Inventory")));

            var packet = (InPacket)deserializer.Deserialize(line);

            Assert.AreEqual((sbyte)-2, packet.InCharacterSubPacket!.ArmorUpgradeRareSubPacket!.Rare);
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void APlayerInAFamilyCarriesTheFamilyRankAndTheBareFamilyName()
        {
            const string line = "in 1 Alice - 6805743 75 3 2 0 0 1 8 3 4642.8647.8631.8639.8687.4132.8680.8682.8748.4443.8696 100 100 0 -1 4 4 0 43 0 3728 77 78 1618.917 Testers 27 0 0 0 5 99 30 0|0|0 0 0 100 99 0";
            var deserializer = new Deserializer(PacketCorpus.SerializableTypes.Where(t => t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Visibility") || t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Inventory")));

            var packet = (InPacket)deserializer.Deserialize(line);

            var character = packet.InCharacterSubPacket!;
            Assert.AreEqual((1618L, Game18NConstString.Familykeeper, "Testers"),
                (character.FamilySubPacket?.FamilyId, character.FamilySubPacket?.FamilyRank, character.FamilyName));
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void APlayerWithoutAFamilySendsOneMinusOneAndADash()
        {
            const string line = "in 1 Bob - 12738248 71 78 2 0 0 0 38 1 337.4918.4900.4911.227.4132.4441.478.8699.4443.-1 100 100 0 -1 4 4 0 43 0 0 97 87 -1 - 23 0 0 0 0 85 0 0|0|0 0 0 100 1 9372";
            var deserializer = new Deserializer(PacketCorpus.SerializableTypes.Where(t => t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Visibility") || t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Inventory")));

            var packet = (InPacket)deserializer.Deserialize(line);

            Assert.AreEqual(((FamilySubPacket?)null, (string?)null),
                (packet.InCharacterSubPacket!.FamilySubPacket, packet.InCharacterSubPacket.FamilyName));
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void TheOwnCharacterInfoWithoutAFamilyHasNoRank()
        {
            Assert.AreEqual("c_info Tester - -1 -1 - 14293841 0 0 2 100 2 19 0 13 0 0 0 0 0 -1",
                Serializer.Serialize(new CInfoPacket
                {
                    Name = "Tester",
                    GroupId = -1,
                    FamilyId = -1,
                    FamilyRank = null,
                    FamilyName = null,
                    CharacterId = 14293841,
                    Authority = AuthorityType.User,
                    Gender = GenderType.Male,
                    HairStyle = HairStyleType.HairStyleC,
                    HairColor = (HairColorType)100,
                    Class = CharacterClassType.Archer,
                    Icon = 19,
                    Morph = 13,
                    Unknown3 = -1,
                }));
        }

        [TestMethod]
        public void ANonPlayerTitleCarriesItsArgument()
        {
            const string line = "in 2 1428 2345 70 66 2 76 100 10000 0 0 -1 1 0 -1 @ 0 -1 0 0 0 0 0 0 0 0 595 Alice 0 0 0";
            var deserializer = new Deserializer(PacketCorpus.SerializableTypes.Where(t => t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Visibility") || t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Inventory")));

            var packet = (InPacket)deserializer.Deserialize(line);

            Assert.AreEqual(Game18NConstString.UserMiniland, packet.InNonPlayerSubPacket!.Title);
            Assert.AreEqual("Alice", packet.InNonPlayerSubPacket.TitleArguments.Single());
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void ANonPlayerTitleWithoutArgumentSendsZero()
        {
            const string line = "in 2 317 3456 49 132 2 100 100 0 0 3 1234 1 0 2789 @ 1 0 1 307 308 309 4237 4238 4239 0 2646 0 0 0 0";
            var deserializer = new Deserializer(PacketCorpus.SerializableTypes.Where(t => t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Visibility") || t.Namespace!.StartsWith("NosCore.Packets.ServerPackets.Inventory")));

            var packet = (InPacket)deserializer.Deserialize(line);
            packet.InNonPlayerSubPacket!.TitleArguments = new Game18NArguments(1);

            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void ALimitedItemGoesOutWithANegativeVNum()
        {
            Assert.AreEqual("ivn 7 1.4283.0.0.0 2.-4115.0.0.0 3.-1.0.0.0",
                Serializer.Serialize(new IvnPacket
                {
                    Type = PocketType.Costume,
                    IvnSubPackets = new List<IvnSubPacket>
                    {
                        new() { Slot = 1, VNum = 4283, SecondUpgrade = 0 },
                        new() { Slot = 2, VNum = 4115, IsLimited = true, SecondUpgrade = 0 },
                        new() { Slot = 3, VNum = -1, IsLimited = true, SecondUpgrade = 0 },
                    }.Select(item => { item.Unknown5 = null; item.Unknown6 = null; return item; }).ToList(),
                }));
        }

        [TestMethod]
        public void ANegativeVNumReadsBackAsALimitedItem()
        {
            var packet = (IvnPacket)Deserializer.Deserialize("ivn 7 2.-4115.0.0.0");

            Assert.AreEqual((short)4115, packet.IvnSubPackets![0].VNum);
            Assert.IsTrue(packet.IvnSubPackets[0].IsLimited);
        }

        [TestMethod]
        public void ABoundCostumeHatSaysItCannotBeTraded()
        {
            const string line = "e_info 3 -4115 20 0 0 0 0 0 0 0 0 2400 0 2 -1 0";
            var deserializer = new Deserializer(new[] { typeof(EInfoCostumeHatPacket) });

            var packet = (EInfoCostumeHatPacket)deserializer.Deserialize(line);

            Assert.AreEqual(TradeRestriction.NotTradable, packet.TradeRestriction);
            Assert.AreEqual((short)4115, packet.ItemVNum);
            Assert.IsTrue(packet.IsLimited);
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void ASpecialistCardInfoLineReadsBackWithItsTrailingFields()
        {
            const string line = "slinfo 0 8890 56 99 75 15 0 2 0 0 0 0 0 2 8 18 12 10 0 5991794 1963.1964.1965.1966.1967.1968.1969.1970.1971.1972 23892160 0 77 0 73 0 20 0 85 0 33 24 14 28 100 42 42 30 28 7 10 4 7 2 13587 5591 0";
            var deserializer = new Deserializer(new[] { typeof(SlInfoPacket) });

            Assert.AreEqual(line, Serializer.Serialize(deserializer.Deserialize(line)));
        }
    }
}
