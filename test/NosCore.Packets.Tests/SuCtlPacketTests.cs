//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Mates;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;
using System.Linq;

namespace NosCore.Packets.Tests
{
    // Lines taken from a packet trace of the live game; the first field always equals the map of the latest c_map.
    [TestClass]
    public class SuCtlPacketTests
    {
        private static readonly IDeserializer Deserializer = new Deserializer(PacketCorpus.SerializableTypes.ToList());
        private static readonly ISerializer Serializer = new Serializer(PacketCorpus.SerializableTypes.ToList());

        [TestMethod]
        public void OneMateSentAtAMonsterIsReadWithTheMap()
        {
            var packet = (SuCtlPacket)Deserializer.Deserialize("suctl 2101 1 7602121 3 7603446");

            Assert.AreEqual((short)2101, packet.MapId);
            Assert.AreEqual((byte)1, packet.Amount);
            Assert.HasCount(1, packet.Mates!);
            Assert.AreEqual((7602121L, VisualType.Monster, 7603446L),
                (packet.Mates![0]!.MateTransportId, packet.Mates[0]!.TargetType, packet.Mates[0]!.TargetId));
        }

        [TestMethod]
        public void SeveralMatesSentAtOnceAreReadAsOneOrderEach()
        {
            var packet = (SuCtlPacket)Deserializer.Deserialize(
                "suctl 4003 5 6244040 3 6244076 6244041 3 6244076 6244042 3 6244076 6244039 3 6244076 5922205 3 6244076");

            Assert.AreEqual((short)4003, packet.MapId);
            Assert.AreEqual((byte)5, packet.Amount);
            CollectionAssert.AreEqual(new[] { 6244040L, 6244041L, 6244042L, 6244039L, 5922205L },
                packet.Mates!.Select(mate => mate!.MateTransportId).ToArray());
            Assert.IsTrue(packet.Mates!.All(mate => mate!.TargetType == VisualType.Monster && mate.TargetId == 6244076));
        }

        [TestMethod]
        public void AMateSentAtAnNpcKeepsTheNpcTarget()
        {
            var packet = (SuCtlPacket)Deserializer.Deserialize("suctl 5 1 7560452 2 4294967195");

            Assert.AreEqual((short)5, packet.MapId);
            Assert.AreEqual((VisualType.Npc, 4294967195L), (packet.Mates![0]!.TargetType, packet.Mates[0]!.TargetId));
        }

        [TestMethod]
        public void TwoMatesAreWrittenAsTheClientSendsThem()
        {
            var packet = new SuCtlPacket
            {
                MapId = 2101,
                Amount = 2,
                Mates =
                [
                    new SuCtlSubPacket { MateTransportId = 7602121, TargetType = VisualType.Monster, TargetId = 7604523 },
                    new SuCtlSubPacket { MateTransportId = 7602126, TargetType = VisualType.Monster, TargetId = 7604523 },
                ],
            };

            Assert.AreEqual("suctl 2101 2 7602121 3 7604523 7602126 3 7604523", Serializer.Serialize(packet));
        }

        [TestMethod]
        [DataRow("suctl 2 1 2710969 3 3308")]
        [DataRow("suctl 1 1 2634441 2 3087")]
        [DataRow("suctl 2101 2 7602121 3 7604523 7602126 3 7604523")]
        [DataRow("suctl 5207 3 7568914 3 7568921 7568913 3 7568921 7568915 3 7568921")]
        [DataRow("suctl 4012 4 5922205 3 6135887 5922210 3 6135887 6131914 3 6135887 6131913 3 6135887")]
        [DataRow("suctl 4003 5 6244040 3 6244076 6244041 3 6244076 6244042 3 6244076 6244039 3 6244076 5922205 3 6244076")]
        public void AnOrderWritesBackUnchanged(string line)
        {
            Assert.AreEqual(line, Serializer.Serialize(Deserializer.Deserialize(line)));
        }
    }
}
