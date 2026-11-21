//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ServerPackets.Player;

namespace NosCore.Packets.Tests
{
    // Lines taken from a packet trace of the live game.
    [TestClass]
    public class BnPacketTests
    {
        private static readonly Serializer Serializer = new(new[] { typeof(BnPacket) });

        private static readonly Deserializer Deserializer = new(new[] { typeof(BnPacket) });

        [TestMethod]
        public void ANoticeWritesItsSpacesAsCarets()
        {
            Assert.AreEqual("bn 0 NosTale^Team^will^NEVER^ask^for^your^password.",
                Serializer.Serialize(new BnPacket { BnNumber = 0, Message = "NosTale Team will NEVER ask for your password." }));
        }

        [TestMethod]
        [DataRow("bn 0 NosTale^Team^will^NEVER^ask^for^your^password.", (byte)0, "NosTale Team will NEVER ask for your password.")]
        [DataRow("bn 7 Game^rules:^Go^to^Forum^>^News^>^Rules", (byte)7, "Game rules: Go to Forum > News > Rules")]
        public void ANoticeReadsBackWithItsSpaces(string line, byte number, string text)
        {
            var packet = (BnPacket)Deserializer.Deserialize(line);

            Assert.AreEqual((number, text), (packet.BnNumber, packet.Message));
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }
    }
}
