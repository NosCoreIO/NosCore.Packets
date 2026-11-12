//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Families;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class GListPacketTests
    {
        private static readonly Deserializer Deserializer = new(new[] { typeof(GListPacket) });

        [TestMethod]
        [DataRow("glist 0 0", GListPacketType.FamilyManagement)]
        [DataRow("glist 0 2", GListPacketType.MemberList)]
        public void EveryLineTheClientSendsIsRead(string wire, GListPacketType type)
        {
            var packet = (GListPacket)Deserializer.Deserialize(wire);

            Assert.IsTrue(packet.IsValid);
            Assert.AreEqual(type, packet.Type);
        }
    }
}
