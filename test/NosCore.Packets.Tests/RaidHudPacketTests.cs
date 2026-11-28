//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Entities;
using NosCore.Packets.ServerPackets.Event;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    // Lines from traces of the Mother Cuby and Zenas raids.
    [TestClass]
    public class RaidHudPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(PacketCorpus.SerializableTypes.ToList());

        private static readonly IDeserializer Deserializer = new Deserializer(PacketCorpus.SerializableTypes.Where(type =>
            type.Namespace?.Contains(".ClientPackets", StringComparison.Ordinal) != true
            || type.GetCustomAttribute<PacketHeaderAttribute>() == null));

        [TestMethod]
        [DataRow("raidbf 0 0 25")]
        [DataRow("raidbf 0 1 20")]
        [DataRow("raidmbf 11 10 3 2 9 9 25")]
        [DataRow("raidmbf 1 0 0 0 14 15 20")]
        [DataRow("rboss 3 2000001 1004753 1006894 282 0")]
        [DataRow("throw 1046 3000001 26 28 31 28 1663")]
        [DataRow("raidfhp 3 1000001.39 1000002.87 1000003.97")]
        [DataRow("raidfmp 3 1000001.82 1000002.95 1000003.100")]
        [DataRow("rdlstf 85 99 23 86.25.3.0.PlayerA.0.1000001.10 85.2.1.1.PlayerB.0.1000004.10")]
        [DataRow("rdlstv 85 99 23 86.25.3.0.PlayerA.0.1000001.10 99.10.1.0.PlayerC.0.1000005.81")]
        [DataRow("raidf 1 1")]
        [DataRow("raidf 2 1000001")]
        [DataRow("raidf 2 -1")]
        [DataRow("raidf 5 0")]
        [DataRow("raidf 4")]
        [DataRow("raid 1 1")]
        [DataRow("raid 2 1000001")]
        [DataRow("raid 1 0")]
        [DataRow("raid 5 0")]
        [DataRow("raid 4")]
        [DataRow("raid 3 1000001.100.100 1000002.74.64 1000003.6.81")]
        [DataRow("raid 2 -1")]
        public void ACapturedRaidLineReadsBackUnchanged(string line)
        {
            Assert.AreEqual(line, Serializer.Serialize(Deserializer.Deserialize(line)));
        }

        [TestMethod]
        public void TheBossBannerFollowsTheStartBanner()
        {
            Assert.AreEqual("raidbf 0 1 25", Serializer.Serialize(new RaidbfPacket
            {
                Type = RaidBannerType.BossDefeated,
                Unknown = 25
            }));
            Assert.AreEqual(RaidBannerType.Started, ((RaidbfPacket)Deserializer.Deserialize("raidbf 0 0 25")).Type);
        }

        [TestMethod]
        public void TheObjectiveCountersGiveTheGoalBeforeWhatIsLeftAndTheLivesTheOtherWayRound()
        {
            var counters = (RaidmbfPacket)Deserializer.Deserialize("raidmbf 11 10 3 2 14 15 25");

            Assert.AreEqual((short)11, counters.MonsterGoal);
            Assert.AreEqual((short)10, counters.MonstersLeft);
            Assert.AreEqual((short)3, counters.SecondGoal);
            Assert.AreEqual((short)2, counters.SecondGoalLeft);
            Assert.AreEqual((short)14, counters.LivesLeft);
            Assert.AreEqual((short)15, counters.Lives);
            Assert.AreEqual((byte)25, counters.Unknown);
        }

        [TestMethod]
        public void TheBossBarNamesTheBossByItsVisualIdAndVNum()
        {
            var bar = (RbossPacket)Deserializer.Deserialize("rboss 3 2000002 9780434 12078540 2504 0");

            Assert.AreEqual(VisualType.Monster, bar.VisualType);
            Assert.AreEqual(2000002L, bar.VisualId);
            Assert.AreEqual(9780434, bar.CurrentHp);
            Assert.AreEqual(12078540, bar.MaxHp);
            Assert.AreEqual((short)2504, bar.VNum);
        }

        [TestMethod]
        public void AThrownItemFliesFromOneCellToAnother()
        {
            Assert.AreEqual("throw 2135 3000002 26 28 18 31 1", Serializer.Serialize(new ThrowPacket
            {
                VNum = 2135,
                VisualId = 3000002,
                FromX = 26,
                FromY = 28,
                ToX = 18,
                ToY = 31,
                Amount = 1
            }));
        }

        [TestMethod]
        public void EachMemberIsItsIdDotItsPercent()
        {
            Assert.AreEqual("raidfhp 3 1000001.39 1000002.100", Serializer.Serialize(new RaidfhpPacket
            {
                Type = 3,
                Members = new List<RaidfMemberSubPacket?>
                {
                    new() { CharacterId = 1000001, Percent = 39 },
                    new() { CharacterId = 1000002, Percent = 100 }
                }
            }));
        }

        [TestMethod]
        public void ATeamStateWithoutValueEndsAtItsType()
        {
            Assert.AreEqual("raidf 4", Serializer.Serialize(new RaidfPacket { Type = 4 }));
            Assert.IsNull(((RaidfPacket)Deserializer.Deserialize("raidf 4")).Value);
        }
    
        [TestMethod]
        public void EachMemberIsItsIdDotItsHpDotItsMp()
        {
            Assert.AreEqual("raid 3 1000001.100.100 1000002.74.64", Serializer.Serialize(new RaidMemberStatsPacket
            {
                Members = new List<RaidMemberStatSubPacket?>
                {
                    new() { CharacterId = 1000001, HpPercent = 100, MpPercent = 100 },
                    new() { CharacterId = 1000002, HpPercent = 74, MpPercent = 64 }
                }
            }));

            var stats = (RaidMemberStatsPacket)Deserializer.Deserialize("raid 3 1000001.6.81");
            Assert.AreEqual(1000001L, stats.Members![0]!.CharacterId);
            Assert.AreEqual((byte)6, stats.Members[0]!.HpPercent);
            Assert.AreEqual((byte)81, stats.Members[0]!.MpPercent);
        }

        [TestMethod]
        public void ARaidStateWithoutValueEndsAtItsType()
        {
            Assert.AreEqual("raid 4", Serializer.Serialize(new RaidPacket { Type = 4 }));
            Assert.AreEqual(-1L, ((RaidPacket)Deserializer.Deserialize("raid 2 -1")).Value);
        }
    }
}
