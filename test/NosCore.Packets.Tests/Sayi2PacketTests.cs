//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Chats;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    // Lines taken from a packet trace of the live game, without the blanks the server leaves at their end.
    [TestClass]
    public class Sayi2PacketTests
    {
        private const string MaintenanceLine =
            "sayi2 1 -1  10 90 999 The servers will be shutdown in 5 minutes for the weekly maintenance.";

        private static readonly Serializer Serializer = new(new[] { typeof(Sayi2Packet) });

        private static readonly Deserializer Deserializer = new(new[] { typeof(Sayi2Packet) });

        [TestMethod]
        public void AnAnnouncementWithoutSenderWritesItsTextAsArgumentType999()
        {
            Assert.AreEqual(MaintenanceLine, Serializer.Serialize(new Sayi2Packet
            {
                VisualType = VisualType.Player,
                VisualId = -1,
                Type = SayColorType.Yellow,
                Message = Game18NConstString.Administrator,
                ArgumentType = 999,
                Game18NArguments = { "The servers will be shutdown in 5 minutes for the weekly maintenance." },
            }));
        }

        [TestMethod]
        public void AnAnnouncementWithoutSenderReadsBack()
        {
            var packet = (Sayi2Packet)Deserializer.Deserialize(MaintenanceLine);

            Assert.AreEqual((-1L, SayColorType.Yellow, Game18NConstString.Administrator, (short)999),
                (packet.VisualId, packet.Type, packet.Message, packet.ArgumentType));
            Assert.AreEqual(MaintenanceLine, Serializer.Serialize(packet));
        }

        [TestMethod]
        [DataRow("sayi2 1 14882169 12 413 9 163 Gold")]
        [DataRow("sayi2 1 14882169 11 664 6 105 4/5")]
        [DataRow("sayi2 1 7601342 16 2643 14 Schmal94 683")]
        public void ALineFromACharacterHasNoEmptyField(string line)
        {
            var packet = (Sayi2Packet)Deserializer.Deserialize(line);

            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void TheGoldReceivedLineCarriesTheAmountAndTheCurrency()
        {
            Assert.AreEqual("sayi2 1 14882169 12 413 9 163 Gold", Serializer.Serialize(new Sayi2Packet
            {
                VisualType = VisualType.Player,
                VisualId = 14882169,
                Type = SayColorType.Green,
                Message = Game18NConstString.ItemReceived,
                ArgumentType = 9,
                Game18NArguments = new Game18NArguments(2) { 163, "Gold" },
            }));
        }
    }
}
