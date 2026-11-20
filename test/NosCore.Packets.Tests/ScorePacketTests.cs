//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.TimeSpaces;
using System.Collections.Generic;
using System.Linq;

namespace NosCore.Packets.Tests
{
    // Lines taken from packet traces of the live game.
    [TestClass]
    public class ScorePacketTests
    {
        private static readonly IDeserializer Deserializer = new Deserializer(PacketCorpus.SerializableTypes.ToList());
        private static readonly ISerializer Serializer = new Serializer(PacketCorpus.SerializableTypes.ToList());

        [TestMethod]
        [DataRow("score  5 0 33 57 0 5 11 7 1 111 1 15")]
        [DataRow("score  5 136 9954 414 0 2 79 5 0 110 1 15")]
        [DataRow("score  5 156 9009 477 0 2 91 29 40 000 1 15")]
        [DataRow("score  5 182 9009 477 0 2 91 24 41 001 1 15")]
        [DataRow("score  5 0 2304 168 0 2 32 12 16 011 1 15")]
        [DataRow("score  5 0 8610 430 7462 0 82 14 0 110 1 15")]
        [DataRow("score  5 557 420 73 0 5 14 5 0 000 1 1")]
        [DataRow("score  5 972 1728 168 0 3 32 23 0 010 0 1")]
        [DataRow("score  5 755 324 47 0 2 9 6 1 011 0 1")]
        [DataRow("score  5 702 0 0 0 0 0 7 1 011 2 1")]
        public void AClearedRunReadsBackAsTheMissionClearLine(string wire)
        {
            var packet = Deserializer.Deserialize(wire);

            Assert.IsInstanceOfType<ScorePacket>(packet);
            Assert.AreEqual(wire, Serializer.Serialize(packet));
        }

        [TestMethod]
        [DataRow("score 1 0 0 0 0 0 0 0 0 0", EndStateType.Timeout)]
        [DataRow("score 3 0 0 0 0 0 0 0 0 0", EndStateType.LivesExhausted)]
        public void AFailedRunReadsBackWithItsEndState(string wire, EndStateType endState)
        {
            var packet = Deserializer.Deserialize(wire);

            Assert.AreEqual(endState, ((ScoreFailedPacket)packet).EndState);
            Assert.AreEqual(wire, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void TheMissionClearLineCarriesTheRewardsCountsAndPerfectCategories()
        {
            var packet = (ScorePacket)Deserializer.Deserialize("score  5 0 8610 430 7462 0 82 14 0 110 1 15");

            Assert.AreEqual(EndStateType.Success, packet.EndState);
            Assert.AreEqual(0, packet.Points);
            Assert.AreEqual(8610, packet.Experience);
            Assert.AreEqual(430, packet.JobExperience);
            Assert.AreEqual(7462, packet.Gold);
            Assert.AreEqual((byte)0, packet.DrawRewardCount);
            Assert.AreEqual((short)82, packet.MonstersKilled);
            Assert.AreEqual((short)14, packet.RoomsExplored);
            Assert.AreEqual((short)0, packet.NpcsLeft);
            CollectionAssert.AreEqual(new List<bool> { true, true, false }, packet.Perfect);
            Assert.AreEqual(TimeSpaceClearType.ClearedBefore, packet.ClearType);
            Assert.AreEqual((byte)15, packet.Unknown);
        }

        [TestMethod]
        public void ALoserModeClearReadsItsPointsAndClearType()
        {
            var packet = (ScorePacket)Deserializer.Deserialize("score  5 702 0 0 0 0 0 7 1 011 2 1");

            Assert.AreEqual(702, packet.Points);
            CollectionAssert.AreEqual(new List<bool> { false, true, true }, packet.Perfect);
            Assert.AreEqual(TimeSpaceClearType.LoserMode, packet.ClearType);
        }

        [TestMethod]
        public void AClearedRunIsWrittenWithTheEmptyFieldBeforeItsEndState()
        {
            var wire = Serializer.Serialize(new ScorePacket
            {
                Points = 1025,
                Experience = 969,
                JobExperience = 99,
                DrawRewardCount = 2,
                MonstersKilled = 19,
                RoomsExplored = 10,
                NpcsLeft = 1,
                Perfect = [true, true, true],
                ClearType = TimeSpaceClearType.FirstClear,
                Unknown = 1
            });

            Assert.AreEqual("score  5 1025 969 99 0 2 19 10 1 111 0 1", wire);
        }

        [TestMethod]
        public void AFailedRunIsWrittenAsItsEndStateAndZeros()
        {
            var wire = Serializer.Serialize(new ScoreFailedPacket { EndState = EndStateType.LivesExhausted });

            Assert.AreEqual("score 3 0 0 0 0 0 0 0 0 0", wire);
        }
    }
}
