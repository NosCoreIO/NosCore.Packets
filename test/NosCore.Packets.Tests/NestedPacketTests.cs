//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.UI;
using System;
using ClientGuri = NosCore.Packets.ClientPackets.UI.GuriPacket;
using ServerGuri = NosCore.Packets.ServerPackets.UI.GuriPacket;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class NestedPacketTests
    {
        private const string Question = "qnamli 1 #guri^506^-1 379 0 0 0";

        [TestMethod]
        public void ANestedTypeReadsTheAnswerOfADialog()
        {
            var deserializer = new Deserializer(new[] { typeof(QnamliPacket), typeof(ServerGuri) }, new[] { typeof(ClientGuri) });

            var answer = (ClientGuri)((QnamliPacket)deserializer.Deserialize(Question)).YesPacket!;

            Assert.AreEqual(GuriPacketType.EventInWaiting, answer.Type);
            Assert.AreEqual(-1, answer.Argument);
        }

        [TestMethod]
        public void AWholeLineIsStillReadWithItsOwnType()
        {
            var deserializer = new Deserializer(new[] { typeof(QnamliPacket), typeof(ServerGuri) }, new[] { typeof(ClientGuri) });

            Assert.IsInstanceOfType<ServerGuri>(deserializer.Deserialize("guri 506 1 0 0"));
        }

        [TestMethod]
        public void WithoutNestedTypesTheAnswerIsReadWithTheWholeLineType()
        {
            var deserializer = new Deserializer(new[] { typeof(QnamliPacket), typeof(ServerGuri) });

            Assert.ThrowsExactly<ArgumentException>(() => deserializer.Deserialize(Question));
        }
    }
}
