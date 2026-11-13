//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Families;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Families;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class FamilyHistoryAndRankingPacketTests
    {
        private static readonly Serializer Serializer = new(new[]
        {
            typeof(FrankStcPacket),
            typeof(FrankStcSubPacket),
            typeof(GhisPacket),
            typeof(GhisSubPacket),
            typeof(FhisStcPacket),
            typeof(TodayStcPacket),
            typeof(FslogStcPacket),
            typeof(FslogStcSubPacket),
        });

        private static readonly Deserializer Deserializer = new(new[]
        {
            typeof(FrankCtsPacket),
            typeof(FhistCtsPacket),
            typeof(FslogCtsPacket),
            typeof(TodayPacket),
        });

        [TestMethod]
        public void TheRankingNamesItsTabThenListsRankNameLevelAndValuePerFamily()
        {
            var packet = Serializer.Serialize(new FrankStcPacket
            {
                Type = FamilyRankingTab.More,
                Entries = new List<FrankStcSubPacket?>
                {
                    new() { Rank = 1, FamilyName = "Alpha", FamilyLevel = 5, Value = 1200 },
                    new() { Rank = 2, FamilyName = "Beta", FamilyLevel = 3, Value = 40 }
                }
            });

            Assert.AreEqual("frank_stc 2 1|Alpha|5|1200 2|Beta|3|40", packet);
        }

        [TestMethod]
        [DataRow(FamilyRankingType.Experience, FamilyRankingTab.Current)]
        [DataRow(FamilyRankingType.CurrentDemons, FamilyRankingTab.Current)]
        [DataRow(FamilyRankingType.LastMonthAngels, FamilyRankingTab.Monthly)]
        [DataRow(FamilyRankingType.DailyReputation, FamilyRankingTab.More)]
        [DataRow(FamilyRankingType.SpireCatacombs, FamilyRankingTab.SpireCatacombs)]
        public void EachRankingIsFiledUnderTheTabThatAsksForIt(FamilyRankingType type, FamilyRankingTab tab)
        {
            Assert.AreEqual(tab, type.Tab());
        }

        [TestMethod]
        public void AHistoryEntryJoinsItsArgumentsBetweenTypeAndAge()
        {
            var packet = Serializer.Serialize(new GhisPacket
            {
                Entries = new List<GhisSubPacket?>
                {
                    new() { Type = FamilyLogType.UserManaged, FirstArgument = "Newbie", SecondArgument = "Head", HoursAgo = 2 },
                    new() { Type = FamilyLogType.FamilyLevelUp, FirstArgument = "4", HoursAgo = 0 }
                }
            });

            Assert.AreEqual("ghis 0 11|Newbie|Head|2 5|4|0", packet);
        }

        [TestMethod]
        public void AWarehouseHistoryClearsTheWindowThenListsWhoMovedWhichItem()
        {
            var packet = Serializer.Serialize(new FslogStcPacket
            {
                Entries = new List<FslogStcSubPacket?>
                {
                    new() { Type = FamilyWarehouseLogType.Withdrawal, CharacterName = "Bud", ItemVNum = 1012, Amount = 3, HoursAgo = 0 },
                    new() { Type = FamilyWarehouseLogType.Deposit, CharacterName = "Tester", ItemVNum = 1, Amount = 1, HoursAgo = 5 }
                }
            });

            Assert.AreEqual("fslog_stc -1 1|Bud|1012|3|0 0|Tester|1|1|5", packet);
        }

        [TestMethod]
        public void TheRefreshAndDailyMessageAnswersCarryNoField()
        {
            Assert.AreEqual("fhis_stc", Serializer.Serialize(new FhisStcPacket()));
            Assert.AreEqual("today_stc", Serializer.Serialize(new TodayStcPacket()));
        }

        [TestMethod]
        [DataRow("frank_cts 0", FamilyRankingType.Experience)]
        [DataRow("frank_cts 3", FamilyRankingType.CurrentDemons)]
        [DataRow("frank_cts 2", FamilyRankingType.CurrentAngels)]
        [DataRow("frank_cts 4", FamilyRankingType.LastMonthExperience)]
        [DataRow("frank_cts 6", FamilyRankingType.LastMonthAngels)]
        [DataRow("frank_cts 7", FamilyRankingType.LastMonthDemons)]
        [DataRow("frank_cts 8", FamilyRankingType.DailyExperience)]
        [DataRow("frank_cts 9", FamilyRankingType.DailyReputation)]
        [DataRow("frank_cts 10", FamilyRankingType.SpireCatacombs)]
        public void TheRankingRequestNamesItsTab(string packet, FamilyRankingType expected)
        {
            Assert.AreEqual(expected, ((FrankCtsPacket)Deserializer.Deserialize(packet)).Type);
        }

        [TestMethod]
        public void TheHistoryAndDailyMessageRequestsHaveNoField()
        {
            Assert.IsInstanceOfType(Deserializer.Deserialize("fhis_cts"), typeof(FhistCtsPacket));
            Assert.IsInstanceOfType(Deserializer.Deserialize("today_cts"), typeof(TodayPacket));
            Assert.IsInstanceOfType(Deserializer.Deserialize("fslog_cts"), typeof(FslogCtsPacket));
        }
    }
}
