//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.CharacterSelectionScreen;
using NosCore.Packets.ServerPackets.Chats;
using NosCore.Packets.ServerPackets.Event;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Packets.ServerPackets.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NosCore.Packets.Tests
{
    // Server lines from packet traces of the live game, read the way a client reads them and written back.
    [TestClass]
    public class TraceLeftoverLineTests
    {
        private static readonly ISerializer Serializer = new Serializer(PacketCorpus.SerializableTypes.ToList());

        private static readonly IDeserializer ClientSide = new Deserializer(PacketCorpus.SerializableTypes
            .Where(t => IsServerPacket(t) || !ServerHeaders.Contains(t.GetCustomAttribute<PacketHeaderAttribute>()?.Identification ?? string.Empty)));

        private static HashSet<string> ServerHeaders => PacketCorpus.PacketTypes.Where(IsServerPacket)
            .Select(t => t.GetCustomAttribute<PacketHeaderAttribute>()!.Identification).ToHashSet();

        private static bool IsServerPacket(Type type) => type.Namespace?.Contains(".ServerPackets", StringComparison.Ordinal) == true;

        private const string Maze = "rbr 3.0.0 4 15 10.99 1 205.1 207.1 208.1 209.1 210.1 203.1 -1.0 10.1 -1.0 -1.0 1120.Anonymous 0 0 A Difficult Decision\rYour skills will be seriously put to the test in this Time-Space. You should be very careful: even a small mistake could have dire consequences! Are you prepared?";

        private const string RunedSword = "e_info 0 8813 8 13 0 99 1564 1764 1078 22 380 0 100 2400000 -1 0 1000001 9 88 1.16.41.2 1.6.3.0 2.12.9.0 2.25.142.2 3.26.17.2 3.18.99.0 4.2.10.-2 12.34.33.0 12.35.30.0 20 0 7 102.0.4.0.1 5.0.32.0.-5 3.0.80.0.1 5.1.12.0.1 44.1.52.0.6 106.3.8.7764.2 106.1.16.7732.4 0";

        private const string BoundFairy = "e_info 4 8672 1 80 0 11641 2000 2 2 7709 1000001 1 1 7 5.16.11 2.10.3 2.9.3 2.7.2 3.5.5 2.6.13 3.4.5";

        [TestMethod]
        [DataRow(Maze)]
        [DataRow("clist 0 Anonymous 0 1 0 9 0 0 1 0 -1.12.1.8.-1.-1.-1.-1.-1.-1.-1 1  1 1 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1. 0 0")]
        [DataRow("clist 0 Anonymous 0 1 0 9 0 0 12 0 203.14.3.8.-1.-1.-1.-1.-1.-1.-1 13  1 1 0.333.0.9.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 0 0")]
        [DataRow("sayitemt 1 1000001 17 1 8813 Anonymous WTS|{%s} " + RunedSword)]
        [DataRow("sayitemt 1 1000002 16 5 8817 Anonymous e_info 5 8817 3 11 0 99 1447 1647 177 0 0 0 100 2400000 -1 0 0 10 82 1.16.53.-1 1.1.85.0 2.13.9.0 2.18.63.1 3.20.125.0 3.12.16.0 4.2.15.0 7.33.12.0 12.35.29.0 12.40.12.0 8 0 4 44.1.40.0.5 3.0.80.0.-1 105.2.4.7640.1 106.4.4.7780.1 0")]
        [DataRow("sayitemt 1 1000003 17 1 8638 Anonymous wts|{%s} e_info 0 8638 6 10 0 88 1054 1214 965 30 497 0 100 1700000 -1 0 1000003 9 83 1.16.50.2 1.17.100.0 2.12.7.0 2.20.57.-1 3.26.14.0 3.24.190.0 4.2.13.0 12.35.26.0 11.38.9.0 485")]
        [DataRow("sayitemt 1 1000004 17 1 8628 Anonymous wts|{%s} e_info 0 8628 7 9 0 90 1420 1562 890 20 325 0 100 2000000 -1 0 1000004 9 -83 1.9.7.0 1.11.7.0 2.26.11.2 2.23.21.0 3.5.1.0 3.1.172.-1 4.2.9.0 12.35.30.0 12.40.11.0 8 0 3 44.1.52.0.-6 105.2.4.7640.1 106.4.4.7780.1 0")]
        [DataRow("sayitemt 1 1000005 17 1 4777 Anonymous {%s}|WTS e_info 0 4777 3 0 0 90 1309 1451 829 20 325 0 100 0 8628 0 0 0 0 0")]
        [DataRow("sayitemt 1 1000006 17 1 4635 Anonymous {%s}|wts e_info 2 4635 7 0 0 65 698 743 701 663 1400000 -1 0 0 10 0 13.2.39.0 13.18.48.0 14.24.7.0 14.10.29.0 15.19.82.0 15.1.188.0 16.4.19.0 19.31.83.0 24.33.31.0 24.37.15.0 0")]
        [DataRow("sayitemt 1 1000007 17 1 4953 Anonymous {%s} e_info 2 4953 8 7 0 28 543 580 637 498 1200000 -1 0 1000007 9 82 13.18.49.0 13.15.46.0 14.1.108.0 14.3.74.-2 15.21.76.0 15.11.50.0 16.17.28.0 19.32.53.0 24.33.37.0 8 0 4 9.0.480.0.-3 102.3.4.0.1 45.0.-16.8.2 117.2.4.5612.2 0")]
        [DataRow("sayitemt 1 1000001 17 1 8672 Anonymous wts|{%s} " + BoundFairy)]
        [DataRow("sayitemt 1 1000008 17 1 8674 Anonymous wts|{%s} e_info 4 8674 3 85 0 5105 2000 2 2 16720 0 0 0")]
        [DataRow("sayitemt 1 1000009 17 1 885 Anonymous wts|{%s} e_info 4 885 2 42 0 1220 280 0 2 4222 0 0 0")]
        [DataRow("sayitemt 1 1000010 17 1 8856 Anonymous wts|{%s} e_info 4 8856 98 10 4 4 1400000 0 10 1698 1 10 1549 2 10 142 5 10 54")]
        [DataRow("sayitemt 1 1000011 17 1 4194 Anonymous WTS|{%s} e_info 12 4194 1 4714 80 1 0 7 4.20.7 2.7.4 3.9.1 3.10.3 2.5.4 4.1.205 2.2.50")]
        [DataRow("sayitemt 1 1000012 17 1 4194 Anonymous WTS|{%s} e_info 12 4194 1 4129 78 0 0 0")]
        [DataRow("sayitemt 1 1000013 17 1 4801 Anonymous {%s}wts e_info 13 4801 1 8582 2 307 6 308 7 309 6 39 14 14 4 11 4 6 2 5")]
        [DataRow("sayitemt 1 1000014 17 1 4801 Anonymous wts{%s} e_info 13 4801 1 8718 4 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0")]
        [DataRow("sayitemt 1 1000015 17 1 4342 Anonymous WTS|{%s} e_info 11 4342 0 -1")]
        [DataRow("sayitemt 1 1000016 17 1 8895 Anonymous WTS|{%s} pslinfo  8895 2 30 30 4 15 30 20 20 1997.7 1998.7 1999.7 17 4 3 2 5 0 0 3 0")]
        public void ATracedLineReadsBackUnchanged(string line)
        {
            var packet = ClientSide.Deserialize(line);

            Assert.IsNotInstanceOfType<UnresolvedPacket>(packet);
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        // A dialog carries the packets the client sends back, so the client's own classes read them.
        private static readonly Deserializer DialogDeserializer = new(new[]
        {
            typeof(DlgiPacket), typeof(ClientPackets.Instance.RStartPacket), typeof(ClientPackets.UI.GuriPacket), typeof(ClientPackets.Event.RevivalPacket),
        });

        [TestMethod]
        [DataRow("dlgi #rstart^1 rstart 92 0 0")]
        [DataRow("dlgi #guri^1000^1^81^33 guri^9999 993 0 0")]
        [DataRow("dlgi #revival^0 #revival^1 570 0 0")]
        public void ADialogCarriesItsAnswersUnchanged(string line)
        {
            Assert.AreEqual(line, Serializer.Serialize(DialogDeserializer.Deserialize(line)));
        }

        [TestMethod]
        public void ATimeSpaceCardKeepsTheSpacesOfItsTitleAndDescription()
        {
            var card = (RbrPacket)ClientSide.Deserialize(Maze);

            Assert.AreEqual("A Difficult Decision", card.TitleAndDescription!.Title);
            StringAssert.StartsWith(card.TitleAndDescription.Description, "Your skills will be seriously put");
        }

        [TestMethod]
        public void ATimeSpaceCardWithoutItsTextsReadsThemAsAbsent()
        {
            const string line = "rbr 3.0.0 4 15 10.99 1 205.1 207.1 208.1 209.1 210.1 203.1 -1.0 10.1 -1.0 -1.0 1120.Anonymous 0 0 -1";
            var card = (RbrPacket)ClientSide.Deserialize(line);

            Assert.IsNull(card.TitleAndDescription);
            Assert.AreEqual(line, Serializer.Serialize(card));
        }

        [TestMethod]
        public void ATimeSpaceCardTitleStartingWithMinusOneKeepsItsTexts()
        {
            const string line = "rbr 3.0.0 4 15 10.99 1 205.1 207.1 208.1 209.1 210.1 203.1 -1.0 10.1 -1.0 -1.0 1120.Anonymous 0 0 -1 A Difficult Decision\rChoose wisely";
            var card = (RbrPacket)ClientSide.Deserialize(line);

            Assert.IsNotNull(card.TitleAndDescription);
            Assert.AreEqual("-1 A Difficult Decision", card.TitleAndDescription.Title);
            Assert.AreEqual("Choose wisely", card.TitleAndDescription.Description);
            Assert.AreEqual(line, Serializer.Serialize(card));
        }

        [TestMethod]
        public void AValidationIsTakenAgainOnEveryCall()
        {
            var fairy = new EInfoFairyPacket { Element = (ElementType)98 };

            Assert.IsFalse(fairy.IsValid);
            Assert.IsFalse(fairy.IsValid);
            Assert.AreEqual(1, fairy.ValidationResult.Count);

            fairy.Element = ElementType.Fire;
            Assert.IsTrue(fairy.IsValid);
            Assert.AreEqual(0, fairy.ValidationResult.Count);
        }

        [TestMethod]
        public void TheNoOfADialogCanBeWrittenWithoutItsHash()
        {
            var dialog = (DlgiPacket)DialogDeserializer.Deserialize("dlgi #rstart^1 rstart 92 0 0");

            Assert.IsFalse(((PacketBase)dialog.YesPacket!).IsWrittenWithoutHash);
            Assert.IsTrue(((PacketBase)dialog.NoPacket!).IsWrittenWithoutHash);
            Assert.AreEqual("dlgi #rstart^1 rstart 92 0 0", Serializer.Serialize(new DlgiPacket
            {
                YesPacket = new ClientPackets.Instance.RStartPacket { Type = RStartPacketType.TimeSpaceInstanceEntry },
                NoPacket = new ClientPackets.Instance.RStartPacket { IsWrittenWithoutHash = true },
                Question = Game18NConstString.WantEnterFirstRoom,
            }));
        }

        [TestMethod]
        public void APetListWithoutPetsEndsWithItsSeparator()
        {
            var empty = new ClistPacket { Pets = Enumerable.Repeat((short?)-1, 26).ToList() };
            var one = new ClistPacket { Pets = new List<short?> { 0, 333 }.Concat(Enumerable.Repeat((short?)-1, 24)).ToList() };

            StringAssert.EndsWith(Serializer.Serialize(empty), "-1.-1. 0 0");
            StringAssert.EndsWith(Serializer.Serialize(one), " 0.333.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 0 0");
        }

        [TestMethod]
        public void AWeaponCarriesItsShellLevelOptionsAndRunes()
        {
            var sword = (EInfoWeaponPacket)ClientSide.Deserialize(RunedSword);

            Assert.AreEqual(((byte)9, (short)88, 9), (sword.ShellOptionCount, sword.ShellLevel, sword.ShellOptions!.Count));
            Assert.AreEqual(((byte)1, (byte)16, 41, (short)2),
                (sword.ShellOptions[0].Level, sword.ShellOptions[0].Type, sword.ShellOptions[0].Value, sword.ShellOptions[0].Unknown));
            Assert.AreEqual(((byte?)20, (byte?)7, 7), (sword.RuneUpgrade, sword.RuneCount, sword.Runes!.Count));
            Assert.AreEqual(((byte)106, (byte)1, 16, 7732, (short)4),
                (sword.Runes[6].Type, sword.Runes[6].SubType, sword.Runes[6].FirstData, sword.Runes[6].SecondData, sword.Runes[6].Unknown));
            Assert.AreEqual((short)0, sword.PityGauge);
        }

        private const string ShelledArmour = "e_info 2 4635 7 0 0 65 698 743 701 663 1400000 -1 0 0 10 0 13.2.39.0 13.18.48.0 14.24.7.0 14.10.29.0 15.19.82.0 15.1.188.0 16.4.19.0 19.31.83.0 24.33.31.0 24.37.15.0 0";

        [TestMethod]
        public void AnArmourReadsItsOptionLevelsAsAWeaponDoes()
        {
            var armour = (EInfoArmorPacket)ClientSide.Deserialize(ShelledArmour);

            Assert.AreEqual(((byte)1, (byte)2, 39, true),
                (armour.ShellOptions![0].Level, armour.ShellOptions[0].Type, armour.ShellOptions[0].Value, armour.ShellOptions[0].IsArmor));
            Assert.AreEqual(((byte)12, (byte)37, 15, true),
                (armour.ShellOptions[9].Level, armour.ShellOptions[9].Type, armour.ShellOptions[9].Value, armour.ShellOptions[9].IsArmor));
        }

        [TestMethod]
        public void AnArmourWritesItsOptionLevelsAsTheTraceDoes()
        {
            var options = new (byte Level, byte Type, int Value)[]
            {
                (1, 2, 39), (1, 18, 48), (2, 24, 7), (2, 10, 29), (3, 19, 82),
                (3, 1, 188), (4, 4, 19), (7, 31, 83), (12, 33, 31), (12, 37, 15),
            };

            var line = Serializer.Serialize(new EInfoArmorPacket
            {
                ItemVNum = 4635,
                Rare = 7,
                LevelMinimum = 65,
                CloseDefence = 698,
                DistanceDefence = 743,
                MagicDefence = 701,
                DefenceDodge = 663,
                Price = 1400000,
                ShellOptionCount = (byte)options.Length,
                ShellOptions = options.Select(o => new EInfoShellOptionSubPacket { Level = o.Level, Type = o.Type, Value = o.Value, IsArmor = true }).ToList(),
            });

            Assert.AreEqual(ShelledArmour, line);
        }

        [TestMethod]
        public void AWeaponWithoutRunesEndsWithItsPityGauge()
        {
            var sword = (EInfoWeaponPacket)((SayItemtPacket)ClientSide.Deserialize("sayitemt 1 1000003 17 1 8638 Anonymous wts|{%s} e_info 0 8638 6 10 0 88 1054 1214 965 30 497 0 100 1700000 -1 0 1000003 9 83 1.16.50.2 1.17.100.0 2.12.7.0 2.20.57.-1 3.26.14.0 3.24.190.0 4.2.13.0 12.35.26.0 11.38.9.0 485")).ItemInfo!;

            Assert.IsNull(sword.RuneUpgrade);
            Assert.IsNull(sword.Runes);
            Assert.AreEqual((short)485, sword.PityGauge);
        }

        [TestMethod]
        public void AFairyCarriesItsExperienceAndOptions()
        {
            var fairy = (EInfoFairyPacket)ClientSide.Deserialize(BoundFairy);

            Assert.AreEqual((ElementType.Fire, (short)80, 11641L, 2000L, 7709L, 1000001L),
                (fairy.Element, fairy.ElementRate, fairy.Experience, fairy.Price, fairy.ExperienceLeft, fairy.BoundCharacterId));
            Assert.AreEqual(((byte?)7, 7), (fairy.OptionCount, fairy.Options!.Count));
            Assert.AreEqual(((byte)5, (byte)16, 11), (fairy.Options[0].Level, fairy.Options[0].Type, fairy.Options[0].Value));
        }

        [TestMethod]
        public void APartnerCardHolderShowsTheHeldCard()
        {
            var holder = (EInfoPartnerSpecialistHolderPacket)ClientSide.Deserialize("e_info 13 4801 1 8582 2 307 6 308 7 309 6 39 14 14 4 11 4 6 2 5");

            Assert.AreEqual(((short?)8582, (ElementType?)ElementType.Water), (holder.HoldingVNum, holder.Element));
            Assert.AreEqual(((short?)307, (byte?)6, (short?)309, (byte?)6), (holder.Skill1VNum, holder.Skill1Rank, holder.Skill3VNum, holder.Skill3Rank));
            Assert.AreEqual((short?)5, holder.DarkPoints);
        }

        [TestMethod]
        public void APartnerCardInfoStartsWithAnEmptyField()
        {
            var card = (PslInfoPacket)ClientSide.Deserialize("pslinfo  8895 2 30 30 4 15 30 20 20 1997.7 1998.7 1999.7 17 4 3 2 5 0 0 3 0");

            Assert.AreEqual(((short)8895, (byte)17), (card.ItemVNum, card.Upgrade));
            StringAssert.StartsWith(Serializer.Serialize(new PslInfoPacket { ItemVNum = 8895 }), "pslinfo  8895 ");
        }
    }
}
