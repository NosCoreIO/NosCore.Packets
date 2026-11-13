//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using ClientGuriPacket = NosCore.Packets.ClientPackets.UI.GuriPacket;
using ServerGuriPacket = NosCore.Packets.ServerPackets.UI.GuriPacket;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class PearlGuriPacketTests
    {
        private static readonly Serializer Serializer = new(new[] { typeof(ServerGuriPacket) });

        private static readonly Deserializer Deserializer = new(new[] { typeof(ClientGuriPacket) });

        [TestMethod]
        public void TheEmptyMountPearlAsksForAMountWithItsSlot()
        {
            Assert.AreEqual("guri 24 0 3",
                Serializer.Serialize(new ServerGuriPacket { Type = GuriPacketType.AddMountInPearl, Argument = 0, EntityId = 3 }));
        }

        [TestMethod]
        public void TheFairyPearlWindowClosesOnGuri27()
        {
            Assert.AreEqual("guri 27 0 0",
                Serializer.Serialize(new ServerGuriPacket { Type = GuriPacketType.CloseFairyPearlWindow }));
        }

        [TestMethod]
        public void TheMountConfirmationCarriesThePearlAndTheMount()
        {
            var packet = (ClientGuriPacket)Deserializer.Deserialize("guri 208 0 3 7 5");

            Assert.AreEqual(GuriPacketType.StoreMountInPearl, packet.Type);
            Assert.AreEqual(0, packet.Argument);
            Assert.AreEqual(3, packet.VisualId);
            Assert.AreEqual(7, packet.Data);
            Assert.AreEqual("5", packet.Value);
        }

        [TestMethod]
        public void TheFairyConfirmationCarriesThePearlAndTheFairy()
        {
            var packet = (ClientGuriPacket)Deserializer.Deserialize("guri 209 0 3 0 2");

            Assert.AreEqual(GuriPacketType.StoreFairyInPearl, packet.Type);
            Assert.AreEqual(3, packet.VisualId);
            Assert.AreEqual(0, packet.Data);
            Assert.AreEqual("2", packet.Value);
        }
    }
}
