//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Battle;
using NosCore.Packets.ServerPackets.Player;

namespace NosCore.Packets.Tests
{
    // Round trips of real captured server lines (headers m-z).
    [TestClass]
    public class CaptureAuditMzTests
    {
        private static readonly Deserializer Deserializer = new(new[] { typeof(ScrPacket), typeof(MslotPacket) });
        private static readonly Serializer Serializer = new(new[] { typeof(ScrPacket), typeof(MslotPacket) });

        [TestMethod]
        public void ScrKeepsItsSeventhField()
        {
            const string line = "scr 0 2 0 0 0 0 0";
            var packet = (ScrPacket)Deserializer.Deserialize(line);
            Assert.AreEqual(2, packet.Unknow2);
            Assert.AreEqual(0, packet.Unknow7);
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void ScrSerializesSevenFields()
        {
            Assert.AreEqual("scr 0 1 0 0 0 0 0", Serializer.Serialize(new ScrPacket { Unknow2 = 1 }));
        }

        [TestMethod]
        public void MslotKeepsSameKey()
        {
            const string line = "mslot 11 -1";
            var packet = (MslotPacket)Deserializer.Deserialize(line);
            Assert.AreEqual(11, packet.SkillCastId);
            Assert.AreEqual(KeyBind.SameKey, packet.KeyId);
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }
    }
}
