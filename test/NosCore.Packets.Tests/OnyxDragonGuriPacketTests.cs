//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.UI;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class OnyxDragonGuriPacketTests
    {
        private static readonly Serializer Serializer = new(new[] { typeof(GuriPacket) });

        [TestMethod]
        public void TheOnyxDragonAppearsBesideTheAttackerAtItsCell()
        {
            Assert.AreEqual("guri 31 1 980516 266 128", Serializer.Serialize(new GuriPacket
            {
                Type = GuriPacketType.OnyxDragon,
                Argument = 1,
                EntityId = 980516,
                Value = 266,
                SecondValue = 128
            }));
        }
    }
}
