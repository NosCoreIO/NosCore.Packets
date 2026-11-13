//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.TimeSpaces;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class MinfoPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(new[] { typeof(MinfoPacket) });
        private static readonly IDeserializer Deserializer = new Deserializer(new[] { typeof(MinfoPacket), typeof(MinfoObjectiveSubPacket), typeof(MinfoConversationSubPacket) });

        [TestMethod]
        public void ObjectivesTheMissionDoesNotHaveAreWrittenTheWayTheClientReadsThem()
        {
            var wire = Serializer.Serialize(new MinfoPacket { GoToExit = true, ProtectNpc = true, MaxLives = 2 });

            Assert.AreEqual("minfo 0 1 -1.0/0 -1.0/0 -1/0 -1.0/0 1 2 0", wire);
        }

        [TestMethod]
        public void AKillObjectiveCarriesTheMonsterAndItsCount()
        {
            var wire = Serializer.Serialize(new MinfoPacket
            {
                KillAllMonsters = true,
                KillMonster = new MinfoObjectiveSubPacket { Vnum = 333, Current = 2, Total = 5 },
                MaxLives = 1
            });

            Assert.AreEqual("minfo 1 0 333.2/5 -1.0/0 -1/0 -1.0/0 0 1 0", wire);
        }
    
        [TestMethod]
        [DataRow("minfo 1 0 333.2/5 -1.0/0 -1/0 -1.0/0 0 1 0")]
        [DataRow("minfo 0 0 -1.0/0 1012.3/10 -1/0 -1.0/0 0 1 0")]
        [DataRow("minfo 0 0 -1.0/0 -1.0/0 2/4 1000.1/3 1 3 0")]
        [DataRow("minfo 0 1 -1.0/0 -1.0/0 -1/0 -1.0/0 1 2 0")]
        public void ObjectivesReadBackFromTheWire(string wire)
        {
            Assert.AreEqual(wire, Serializer.Serialize(Deserializer.Deserialize(wire)));
        }
    }
}
