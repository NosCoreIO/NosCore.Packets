//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Portals;
using NosCore.Packets.ServerPackets.UI;

namespace NosCore.Packets.Tests
{
    // Lines below come from a real client capture. Enums that declare a -1 member must keep it
    // through a deserialize/serialize round trip instead of collapsing to their default value.
    [TestClass]
    public class CapturedEnumMinusOneTests
    {
        private static readonly Deserializer Deserializer = new(new[] { typeof(GpPacket), typeof(AscrPacket) });
        private static readonly Serializer Serializer = new(new[] { typeof(GpPacket), typeof(AscrPacket) });

        [TestMethod]
        public void GpKeepsTheMapPortalTypeFromACapturedLine()
        {
            const string captured = "gp 79 2 2 -1 0 0";

            var packet = (GpPacket)Deserializer.Deserialize(captured);

            Assert.AreEqual(PortalType.MapPortal, packet.PortalType);
            Assert.AreEqual(captured, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void AscrKeepsTheCloseTypeFromACapturedLine()
        {
            const string captured = "ascr  50869 28156 0 0 0 0 0 0 -1";

            var packet = (AscrPacket)Deserializer.Deserialize(captured);

            Assert.AreEqual(AscrPacketType.Close, packet.Type);
            Assert.AreEqual(captured, Serializer.Serialize(packet));
        }
    }
}
