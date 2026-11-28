//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Battle;
using NosCore.Packets.ServerPackets.Quest;
using NosCore.Packets.ServerPackets.UI;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class AbsentFieldTests
    {
        private static readonly Serializer Serializer = new(new[]
        {
            typeof(VbPacket), typeof(BSInfoPacket), typeof(QnpcPacket), typeof(QnpcSubPacket)
        });

        private static readonly Deserializer Deserializer = new(new[]
        {
            typeof(VbPacket), typeof(BSInfoPacket), typeof(QnpcPacket), typeof(QnpcSubPacket)
        });

        [TestMethod]
        public void ABuffWithoutACountdownWritesNoTime()
        {
            Assert.AreEqual("vb 340 1 -1", Serializer.Serialize(new VbPacket { CardId = 340, IsActivated = true }));
        }

        [TestMethod]
        public void ASearchWindowWithoutACountdownWritesNoTime()
        {
            Assert.AreEqual("bsinfo 1 2 -1 2", Serializer.Serialize(new BSInfoPacket
            {
                Mode = BsInfoMode.Update,
                Title = BscPacketType.TalentArena,
                Text = BsInfoText.OpposingTeamFound,
            }));
        }

        [TestMethod]
        public void AnUnusedQuestOfferWritesEveryFieldAbsent()
        {
            var packet = new QnpcPacket
            {
                SubPackets = [new() { Unknown0 = 331, Unknown1 = 1, Unknown2 = 19 }, .. Enumerable.Range(0, 9).Select(_ => new QnpcSubPacket())]
            };

            Assert.AreEqual("qnpc 331|1|19 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1",
                Serializer.Serialize(packet));
        }

        [TestMethod]
        public void AnUnusedQuestOfferReadsBackAsAbsent()
        {
            var packet = (QnpcPacket)Deserializer.Deserialize("qnpc -1|1|19 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1");

            Assert.AreEqual(((short?)null, (short?)1, (short?)null), (packet.SubPackets[0].Unknown0, packet.SubPackets[0].Unknown1, packet.SubPackets[1].Unknown0));
        }
    }
}
