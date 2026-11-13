//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Mates;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class IbPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(new[] { typeof(IbPacket) });

        [TestMethod]
        public void ThePetBasketIsSentAsItsItemVNum()
        {
            var wire = Serializer.Serialize(new IbPacket { Storage = CarriedStorageType.PetBasket, IsAvailable = true });

            Assert.AreEqual("ib 1278 1", wire);
        }

        [TestMethod]
        public void ThePartnerBackpackIsSentAsItsItemVNum()
        {
            var wire = Serializer.Serialize(new IbPacket { Storage = CarriedStorageType.PartnerBackpack, IsAvailable = false });

            Assert.AreEqual("ib 1275 0", wire);
        }
    }
}
