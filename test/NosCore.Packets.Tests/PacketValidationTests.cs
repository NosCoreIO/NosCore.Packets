//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Event;
using NosCore.Packets.ClientPackets.Miniland;
using NosCore.Packets.ClientPackets.Player;
using NosCore.Packets.ClientPackets.Shops;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class PacketValidationTests
    {
        private static readonly IDeserializer Deserializer = new Deserializer(typeof(IPacket).Assembly.GetTypes()
            .Where(p => p.GetInterfaces().Contains(typeof(IPacket)) && p.IsClass && !p.IsAbstract).ToList());

        [TestMethod]
        [DataRow("put 1 3 0")]
        [DataRow("put 1 3 -5")]
        [DataRow("mvi 1 -1 1 3")]
        [DataRow("mvi 1 2 0 3")]
        [DataRow("mve 0 -1 0 3")]
        [DataRow("mve 0 1 0 -3")]
        [DataRow("deposit 1 2 0 4 0")]
        [DataRow("f_deposit 1 2 -1 4")]
        [DataRow("repos 2 0 4 0")]
        [DataRow("f_repos 2 -3 4")]
        [DataRow("withdraw 2 -1 0")]
        [DataRow("withdraw -2 1 0")]
        [DataRow("f_withdraw 2 0")]
        [DataRow("u_i 1 1 1 -1 0")]
        [DataRow("buy 2 1 -1 1")]
        [DataRow("walk -1 4 0 11")]
        [DataRow("u_as 1 4 -1")]
        [DataRow("rmvobj -1")]
        [DataRow("glmk")]
        [DataRow("%Familyinvite")]
        [DataRow("$Party")]
        [DataRow("Char_REN 1")]
        public void ANegativeSlotOrAmountOrAMissingNameIsRejected(string packet)
        {
            Assert.IsFalse(Deserializer.Deserialize(packet).IsValid, packet);
        }

        [TestMethod]
        [DataRow("put 1 3 2")]
        [DataRow("mvi 1 0 1 3")]
        [DataRow("mve 0 0 0 3")]
        [DataRow("deposit 1 2 5 4 0")]
        [DataRow("withdraw 2 1 0")]
        [DataRow("f_withdraw 2 1")]
        [DataRow("walk 12 4 0 11")]
        [DataRow("%Familyinvite Bob")]
        public void AnOrdinaryRequestStaysValid(string packet)
        {
            Assert.IsTrue(Deserializer.Deserialize(packet).IsValid, packet);
        }

        [TestMethod]
        public void TheMinigameWindowSendsItsActionAsAType()
        {
            var packet = (MinigamePacket)Deserializer.Deserialize("mg 8 3 3117 2");
            Assert.AreEqual(MinigamePacketType.OpenGiftBatch, packet.Type);
            Assert.IsTrue(packet.IsValid);
        }

        [TestMethod]
        public void AnUnknownProductionRequestIsRejected()
        {
            Assert.AreEqual(PdtsePacketType.ShowRecipe, ((PdtsePacket)Deserializer.Deserialize("pdtse 1 1012 0 0 0")).Type);
            Assert.IsFalse(Deserializer.Deserialize("pdtse 5 1012 0 0 0").IsValid);
        }

        [TestMethod]
        public void TheTitleWindowTellsVisibilityFromEffect()
        {
            Assert.AreEqual(TitEqPacketType.ToggleVisibility, ((TitEqPacket)Deserializer.Deserialize("tit_eq 1 9300")).Mode);
            Assert.AreEqual(TitEqPacketType.ToggleEffect, ((TitEqPacket)Deserializer.Deserialize("tit_eq 2 9300")).Mode);
        }

        [TestMethod]
        public void TheTimeSpaceEntranceSendsItsButtonsAsFlags()
        {
            var packet = (TreqPacket)Deserializer.Deserialize("treq 10 12 1 0");
            Assert.IsTrue(packet.StartPress);
            Assert.IsFalse(packet.RecordPress);
        }

        [TestMethod]
        public void EquipmentInfoNamesThePocketItLooksIn()
        {
            Assert.AreEqual(EquipmentInfoType.Specialist, ((EquipmentInfoPacket)Deserializer.Deserialize("eqinfo 7 3")).Type);
        }
    }
}
