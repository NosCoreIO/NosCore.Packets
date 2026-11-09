//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Event;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class RaidPartyPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(new[] { typeof(RdlstPacket), typeof(RaidListPacket) });

        [TestMethod]
        public void TheRaidPartyListsEachMemberAsOneDottedField()
        {
            var wire = Serializer.Serialize(new RdlstPacket
            {
                MinimumLevel = 30,
                MaximumLevel = 49,
                RaidType = 0,
                Members = new List<RdlstSubPacket?>
                {
                    new()
                    {
                        Level = 45, Morph = -1, Class = CharacterClassType.Swordsman, Deaths = 0, Name = "Leader",
                        Gender = GenderType.Female, CharacterId = 12, HeroLevel = 0
                    },
                    new()
                    {
                        Level = 33, Morph = 2, Class = CharacterClassType.Archer, Deaths = 1, Name = "Member",
                        Gender = GenderType.Male, CharacterId = 40, HeroLevel = 3
                    }
                }
            });

            Assert.AreEqual("rdlst 30 49 0 45.-1.1.0.Leader.1.12.0 33.2.2.1.Member.0.40.3", wire);
        }

        [TestMethod]
        public void TheRaidListGivesTheReaderStateThenOneEntryPerTeam()
        {
            var wire = Serializer.Serialize(new RaidListPacket
            {
                Type = RaidListType.UnlistedLeader,
                Raids = new List<RaidListSubPacket?>
                {
                    new()
                    {
                        RaidId = 0, MinimumLevel = 30, MaximumLevel = 49, LeaderName = "Leader", LeaderLevel = 45,
                        LeaderMorph = -1, LeaderClass = CharacterClassType.Mage, LeaderGender = GenderType.Male,
                        MemberCount = 4, LeaderHeroLevel = 0
                    }
                }
            });

            Assert.AreEqual("rl 2 0.30.49.Leader.45.-1.3.0.4.0", wire);
        }

        [TestMethod]
        public void AnEmptyRaidListIsTheReaderStateAlone()
        {
            var wire = Serializer.Serialize(new RaidListPacket { Type = RaidListType.NotInTeam, Raids = new List<RaidListSubPacket?>() });

            Assert.AreEqual("rl 0", wire.TrimEnd());
        }
    }
}
