//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Quest;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class SqstPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(new[] { typeof(SqstPacket) });

        [TestMethod]
        public void ABlockWithoutCompletedQuestsIsAllZeros()
        {
            var wire = Serializer.Serialize(SqstPacket.FromCompletedQuests(0, []));

            Assert.AreEqual("sqst  0 " + new string('0', 250), wire);
        }

        [TestMethod]
        public void CompletedQuestsSetTheirBitsLikeTheTrace()
        {
            var packet = SqstPacket.FromCompletedQuests(4, [6040, 6041, 6042, 6076, 6134, 6135]);

            Assert.AreEqual((byte)4, packet.Type);
            Assert.AreEqual("000000OW00008000000000600", packet.Bitmap![..25]);
            Assert.AreEqual(250, packet.Bitmap.Length);
        }

        [TestMethod]
        public void QuestsOfOtherBlocksAreLeftOut()
        {
            var packet = SqstPacket.FromCompletedQuests(3, [6040, 1500]);

            Assert.AreEqual(new string('0', 250), packet.Bitmap);
        }

        [TestMethod]
        public void ASixQuestGroupFillsTheWholeCharacter()
        {
            var packet = SqstPacket.FromCompletedQuests(0, [0, 1, 2, 3, 4, 5]);

            Assert.AreEqual('}', packet.Bitmap![0]);
            Assert.AreEqual(0, SqstPacket.BlockOf(1499));
            Assert.AreEqual(9, SqstPacket.BlockOf(13857));
        }
    }
}
