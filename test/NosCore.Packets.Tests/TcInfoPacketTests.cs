//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Player;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class TcInfoPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(new[] { typeof(TcInfoPacket) });

        [TestMethod]
        public void NoFamilyIsTwoFields()
        {
            var wire = Serializer.Serialize(new TcInfoPacket { Level = 1, Name = "Tester" });

            StringAssert.StartsWith(wire, "tc_info 1 Tester 0 0 0 0 -1 - ");
        }

        [TestMethod]
        public void TheFamilyIdAndNameAreSeparateFields()
        {
            var wire = Serializer.Serialize(new TcInfoPacket
            {
                Level = 1, Name = "Tester", FamilyId = 7, FamilyName = "Fam(Head)"
            });

            StringAssert.StartsWith(wire, "tc_info 1 Tester 0 0 0 0 7 Fam(Head) ");
        }

        [TestMethod]
        public void TheBiographyKeepsItsWordsTogether()
        {
            var wire = Serializer.Serialize(new TcInfoPacket { Name = "Tester", Biography = "Hello there friend" });

            StringAssert.EndsWith(wire, " Hello\vthere\vfriend");
        }

        [TestMethod]
        public void NoBiographyShowsTheClientsNoIntroductionLine()
        {
            var wire = Serializer.Serialize(new TcInfoPacket { Name = "Tester" });

            StringAssert.EndsWith(wire, " 833");
        }

        [TestMethod]
        public void TheBiographyIsTheThirtyNinthField()
        {
            var wire = Serializer.Serialize(new TcInfoPacket { Name = "Tester", Biography = "Hi" });

            var fields = wire.Split(' ');
            Assert.AreEqual(40, fields.Length);
            Assert.AreEqual("Hi", fields[39]);
        }
    }
}
