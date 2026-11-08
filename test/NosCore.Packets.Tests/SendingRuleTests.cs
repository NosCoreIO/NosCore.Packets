//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.ClientPackets.Event;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class SendingRuleTests
    {
        [TestMethod]
        public void OnlyTheDeathScreenPacketsAreAcceptedWhileDead()
        {
            var headers = PacketCorpus.PacketTypes
                .Select(t => t.GetCustomAttribute<PacketHeaderAttribute>()!)
                .Where(h => h.Scopes.HasFlag(Scope.WhileDead))
                .Select(h => h.Identification)
                .OrderBy(h => h, System.StringComparer.Ordinal)
                .ToArray();

            CollectionAssert.AreEqual(new[]
            {
                "/", "0", ":", ";", "bldel", "blins", "btk", "c_close", "eqinfo", "fdel", "fins", "game_start",
                "hero", "ncif", "npinfo", "pjoin", "pleave", "pulse", "qset", "req_info", "revival", "say", "snap"
            }, headers);
        }

        [TestMethod]
        public void RevivingIsRefusedWhileAlive()
        {
            var refusal = typeof(RevivalPacket).GetCustomAttribute<RefusedWhileAttribute>()!;
            Assert.AreEqual(SenderState.Alive, refusal.States);
            Assert.IsNull(refusal.Message);
        }

        [TestMethod]
        public void ACodeWithNoNameMakesThePacketInvalid()
        {
            var packet = (RevivalPacket)new Deserializer(new[] { typeof(RevivalPacket) }).Deserialize("revival 3");
            Assert.IsFalse(packet.IsValid);
        }
    }
}
