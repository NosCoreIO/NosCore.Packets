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
    public class RaidPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(new[]
        {
            typeof(RdlstPacket), typeof(RdlstSubPacket), typeof(ServerRlPacket), typeof(ServerRlSubPacket)
        });

        [TestMethod]
        public void EachTeamMemberIsOneDottedEntry()
        {
            var wire = Serializer.Serialize(new RdlstPacket
            {
                LevelMinimum = 20,
                LevelMaximum = 99,
                RaidId = 0,
                Members = new List<RdlstSubPacket?>
                {
                    new()
                    {
                        Level = 40, Morph = -1, Class = CharacterClassType.Archer, Deaths = 1, Name = "Alice",
                        Gender = GenderType.Female, CharacterId = 7, HeroLevel = 0
                    },
                    new()
                    {
                        Level = 45, Morph = 1, Class = CharacterClassType.Swordsman, Deaths = 0, Name = "Bob",
                        Gender = GenderType.Male, CharacterId = 8, HeroLevel = 3
                    },
                },
            });

            Assert.AreEqual("rdlst 20 99 0 40.-1.2.1.Alice.1.7.0 45.1.1.0.Bob.0.8.3", wire);
        }

        [TestMethod]
        public void EachListedTeamIsOneDottedEntry()
        {
            var wire = Serializer.Serialize(new ServerRlPacket
            {
                Mode = 0,
                Teams = new List<ServerRlSubPacket?>
                {
                    new()
                    {
                        RaidId = 2, LevelMinimum = 30, LevelMaximum = -10, LeaderName = "Alice", LeaderLevel = 50,
                        LeaderMorph = -1, LeaderClass = CharacterClassType.Mage, LeaderGender = GenderType.Female,
                        MemberCount = 3, LeaderHeroLevel = 0
                    },
                },
            });

            Assert.AreEqual("rl 0 2.30.-10.Alice.50.-1.3.1.3.0", wire);
        }
    }
}
