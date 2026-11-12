//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Shops;
using NosCore.Shared.Enumerations;
using NosCore.Packets.ServerPackets.Shop;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class SkillShopPacketTests
    {
        private static readonly Deserializer Deserializer = new(new[] { typeof(BuyPacket) });
        private static readonly Serializer Serializer = new(new[] { typeof(NInvPacket) });

        [TestMethod]
        public void ASkillShopListsItsSkillsSeparatedBySpaces()
        {
            var packet = Serializer.Serialize(new NInvPacket
            {
                VisualType = VisualType.Npc,
                VisualId = 1893,
                Unknown = 0,
                ShopKind = 0,
                Skills = new List<short> { 20, 24, 28 }
            });

            Assert.AreEqual("n_inv 2 1893 0 0 20 24 28", packet);
        }

        [TestMethod]
        public void ASkillPurchaseHasNoAmount()
        {
            var packet = (BuyPacket)Deserializer.Deserialize("buy 2 1893 20");

            Assert.IsTrue(packet.IsValid);
            Assert.AreEqual(VisualType.Npc, packet.VisualType);
            Assert.AreEqual(1893, packet.VisualId);
            Assert.AreEqual(20, packet.Slot);
            Assert.IsNull(packet.Amount);
        }

        [TestMethod]
        public void AnItemPurchaseStillCarriesItsAmount()
        {
            var packet = (BuyPacket)Deserializer.Deserialize("buy 2 1893 3 5");

            Assert.IsTrue(packet.IsValid);
            Assert.AreEqual((short)5, packet.Amount);
        }

        [TestMethod]
        public void AnItemPurchaseOfNothingIsRejected()
        {
            Assert.IsFalse(Deserializer.Deserialize("buy 2 1893 3 0").IsValid);
        }
    }
}
