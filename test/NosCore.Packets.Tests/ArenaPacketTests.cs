//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------


using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Arena;
using NosCore.Packets.ServerPackets.UI;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class ArenaPacketTests
    {
        private static readonly ISerializer Serializer = new Serializer(new[]
        {
            typeof(TaPPacket), typeof(TaPSubPacket), typeof(TaPsPacket), typeof(TaPsSubPacket), typeof(BSInfoPacket)
        });

        [TestMethod]
        public void AnEmptyTeamSlotIsFiveMinusOnes()
        {
            var wire = Serializer.Serialize(new TaPPacket
            {
                Type = TaWindowMode.Open,
                TeamType = ArenaTeamType.Erenia,
                CallsLeft = 5,
                OpponentCallsLeft = 4,
                Fighters = new List<TaPSubPacket?>
                {
                    new() { IsAlive = true, CharacterId = 7, Class = CharacterClassType.Swordsman, Gender = GenderType.Female, Morph = 0 },
                    new(),
                },
            });

            Assert.AreEqual("ta_p 0 2 5 4 1.7.1.1.0 -1.-1.-1.-1.-1", wire);
        }

        [TestMethod]
        public void TheBarsOfAnEmptySlotAreMinusOnes()
        {
            var wire = Serializer.Serialize(new TaPsPacket
            {
                Fighters = new List<TaPsSubPacket?> { new() { CharacterId = 7, HpPercent = 50, MpPercent = 70 }, new() },
            });

            Assert.AreEqual("ta_ps 7.50.70 -1.-1.-1", wire);
        }

        [TestMethod]
        public void TheSearchWindowCanHaveNoCountdown()
        {
            var wire = Serializer.Serialize(new BSInfoPacket
            {
                Mode = BsInfoMode.Update, Title = BscPacketType.TalentArena, Time = -1, Text = BsInfoText.TeammatesFound,
            });

            Assert.AreEqual("bsinfo 1 2 -1 6", wire);
        }
    }
}
