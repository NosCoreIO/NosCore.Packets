//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ServerPackets.Chats;
using NosCore.Packets.ClientPackets.Chat;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class BubblePacketTests
    {
        private static readonly Serializer Serializer =
            new(new[] { typeof(BubblePacket), typeof(BubbleReplyPacket) });

        private static readonly Deserializer Deserializer = new(new[] { typeof(ClientBubblePacket) });

        [TestMethod]
        public void TheBubbleWritesItsSpacesAsVerticalTabs()
        {
            Assert.AreEqual("csp 7 Hello\vthere",
                Serializer.Serialize(new BubblePacket { CharacterId = 7, Message = "Hello there" }));
        }

        [TestMethod]
        public void TheOwnBubbleWritesItsSpacesAsVerticalTabs()
        {
            Assert.AreEqual("csp_r Hello\vthere",
                Serializer.Serialize(new BubbleReplyPacket { Message = "Hello there" }));
        }

        [TestMethod]
        public void TheAnnouncedBubbleReadsVerticalTabsAsSpaces()
        {
            var packet = (ClientBubblePacket)Deserializer.Deserialize("csp 7 Hello\vthere");

            Assert.AreEqual(7, packet.CharacterId);
            Assert.AreEqual("Hello there", packet.Message);
        }
    }
}
