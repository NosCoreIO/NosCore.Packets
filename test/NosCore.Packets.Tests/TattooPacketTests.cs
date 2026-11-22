//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Player;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class TattooPacketTests
    {
        private static readonly Deserializer Deserializer = new(new[] { typeof(UpgradePacket) });

        [TestMethod]
        public void ApplyingATattooNamesThePatternsPocketAndSlot()
        {
            var packet = (UpgradePacket)Deserializer.Deserialize("up_gr 81 1 3 1");

            Assert.AreEqual(UpgradePacketType.ApplyTattoo, packet.UpgradeType);
            Assert.AreEqual(PocketType.Main, packet.InventoryType);
            Assert.AreEqual((byte)3, packet.Slot);
        }
    }
}
