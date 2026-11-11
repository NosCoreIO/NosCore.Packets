//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Mates;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class ScnPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(new[] { typeof(ScnPacket) });

        [TestMethod]
        public void ThePartnerSpAndItsSkillsAreOneDottedFieldEach()
        {
            var wire = Serializer.Serialize(new ScnPacket
            {
                Name = "@",
                MorphId = 2378,
                SpDetails = new ScnPacket.ScSpDetails { ItemId = 4825, AgilityPercentage = 100 },
                Skill1Details = new ScnPacket.ScSkillDetails { SkillId = 1306, Rank = SpPartnerRank.F },
                Unknown5 = 1,
                Unknown6 = 0
            });

            StringAssert.EndsWith(wire, " @ 2378 0 4825.100 1306.1 -1 -1 0 1 0");
        }
    }
}
