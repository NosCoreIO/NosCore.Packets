//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Chat;

namespace NosCore.Packets.Tests
{
    // Lines the game client sends from a friend's conversation window.
    [TestClass]
    public class BtkPacketTests
    {
        private static readonly Deserializer Deserializer = new(new[] { typeof(BtkPacket) });

        [TestMethod]
        public void TheFriendsNameComesBeforeTheMessage()
        {
            var packet = (BtkPacket)Deserializer.Deserialize("btk 3 test ca va ?");

            Assert.AreEqual(3, packet.CharacterId);
            Assert.AreEqual("test", packet.CharacterName);
            Assert.AreEqual("ca va ?", packet.Message);
        }
    }
}
