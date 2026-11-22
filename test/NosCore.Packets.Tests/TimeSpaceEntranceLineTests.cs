//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Event;
using NosCore.Packets.ClientPackets.Instance;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.UI;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class TimeSpaceEntranceLineTests
    {
        private static readonly Serializer Serializer = new(new[] { typeof(WreqPacket), typeof(TreqPacket), typeof(QnaiPacket) });

        private static readonly Deserializer Deserializer = new(new[] { typeof(WreqPacket), typeof(TreqPacket), typeof(QnaiPacket) });

        [TestMethod]
        public void SteppingOntoAStoneSendsAWreqWithNoValue()
        {
            var packet = (WreqPacket)Deserializer.Deserialize("wreq");

            Assert.IsNull(packet.Value);
            Assert.IsNull(packet.Param);
            Assert.IsTrue(packet.IsValid);
            Assert.AreEqual("wreq", Serializer.Serialize(packet));
        }

        [TestMethod]
        [DataRow("wreq 1", WreqPacketType.InstanceEntry, null)]
        [DataRow("wreq 5", WreqPacketType.InstanceEntryLoserMode, null)]
        [DataRow("wreq 1 1", WreqPacketType.InstanceEntry, 1L)]
        public void AWreqWithAValueReadsBackUnchanged(string line, WreqPacketType value, long? param)
        {
            var packet = (WreqPacket)Deserializer.Deserialize(line);

            Assert.AreEqual(value, packet.Value);
            Assert.AreEqual(param, packet.Param);
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void TheRecordChallengeQuestionCarriesTheAcceptedGoldInItsAnswer()
        {
            const string line = "qnai #treq^8^45^1^1^1 605 4 850 0";
            var question = (QnaiPacket)Deserializer.Deserialize(line);
            var answer = (TreqPacket)question.YesPacket!;

            Assert.AreEqual(Game18NConstString.GoldRequiredToChallengeRecord, question.Question);
            Assert.AreEqual(8, answer.X);
            Assert.AreEqual(45, answer.Y);
            Assert.IsTrue(answer.StartPress);
            Assert.IsTrue(answer.RecordPress);
            Assert.IsTrue(answer.GoldAccepted);
            Assert.AreEqual(line, Serializer.Serialize(question));
        }

        [TestMethod]
        public void TheAcceptedRecordChallengeReadsBackUnchanged()
        {
            var packet = (TreqPacket)Deserializer.Deserialize("treq 8 45 1 1 1");

            Assert.IsTrue(packet.GoldAccepted);
            Assert.AreEqual("treq 8 45 1 1 1", Serializer.Serialize(packet));
        }
    }
}
