//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Event;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.UI;
using ClientGuriPacket = NosCore.Packets.ClientPackets.UI.GuriPacket;
using ServerGuriPacket = NosCore.Packets.ServerPackets.UI.GuriPacket;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class ScriptTeleportAndRaidWindowPacketTests
    {
        private static readonly Serializer Serializer = new(new[] { typeof(DlgiPacket), typeof(ClientGuriPacket) });

        private static readonly Deserializer Deserializer = new(new[] { typeof(ClientGuriPacket), typeof(ServerGuriPacket), typeof(RaidopenPacket) });

        [TestMethod]
        public void TheScriptTeleportQuestionIsWrittenAsTheTraceShows()
        {
            Assert.AreEqual("dlgi #guri^1000^1^81^33 guri^9999 993 0 0", Serializer.Serialize(new DlgiPacket
            {
                YesPacket = new ClientGuriPacket { Type = GuriPacketType.ScriptTeleport, Argument = 1, VisualId = 81, Data = 33 },
                NoPacket = new ClientGuriPacket { Type = GuriPacketType.ScriptTeleportDeclined, IsWrittenWithoutHash = true },
                Question = Game18NConstString.TeleportNow
            }));
        }

        [TestMethod]
        public void TheYesAnswerCarriesTheMapThenTheCell()
        {
            var packet = (ClientGuriPacket)Deserializer.Deserialize("#guri^1000^3^173^186");

            Assert.AreEqual(GuriPacketType.ScriptTeleport, packet.Type);
            Assert.AreEqual(3, packet.Argument);
            Assert.AreEqual(173L, packet.VisualId);
            Assert.AreEqual(186L, packet.Data);
        }

        [TestMethod]
        public void TheNoAnswerIsReadAsTheDeclinedGuri()
        {
            var packet = (ClientGuriPacket)Deserializer.Deserialize("guri^9999");

            Assert.AreEqual(GuriPacketType.ScriptTeleportDeclined, packet.Type);
            Assert.IsNull(packet.Argument);
        }

        [TestMethod]
        public void OpeningTheRaidWindowIsReadAsTheClientPacket()
        {
            Assert.IsInstanceOfType<RaidopenPacket>(Deserializer.Deserialize("raidopen"));
        }
    }
}
