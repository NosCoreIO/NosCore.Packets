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

            Assert.AreEqual("tc_info 1 Tester 0 0 0 0 -1 - 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 833", wire);
        }

        [TestMethod]
        public void TheFamilyIdAndNameAreSeparateFields()
        {
            var wire = Serializer.Serialize(new TcInfoPacket
            {
                Level = 1, Name = "Tester", FamilyId = 7, FamilyName = "Fam(Head)"
            });

            Assert.AreEqual("tc_info 1 Tester 0 0 0 0 7 Fam(Head) 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 833", wire);
        }

        [TestMethod]
        public void TheBiographyKeepsItsWordsTogether()
        {
            var wire = Serializer.Serialize(new TcInfoPacket { Name = "Tester", Biography = "Hello there friend" });

            Assert.AreEqual("tc_info 0 Tester 0 0 0 0 -1 - 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 Hello\vthere\vfriend", wire);
        }

        [TestMethod]
        public void NoBiographyShowsTheClientsNoIntroductionLine()
        {
            var wire = Serializer.Serialize(new TcInfoPacket { Name = "Tester" });

            Assert.AreEqual("tc_info 0 Tester 0 0 0 0 -1 - 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 833", wire);
        }

        [TestMethod]
        public void TheBiographyIsTheThirtyNinthField()
        {
            var wire = Serializer.Serialize(new TcInfoPacket { Name = "Tester", Biography = "Hi" });

            Assert.AreEqual("tc_info 0 Tester 0 0 0 0 -1 - 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 Hi", wire);
        }
    }
}
