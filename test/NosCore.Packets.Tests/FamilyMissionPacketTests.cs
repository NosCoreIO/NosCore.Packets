//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Families;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class FamilyMissionPacketTests
    {
        private static readonly Serializer Serializer = new(new[]
        {
            typeof(FmiPacket),
            typeof(FmiSubPacket),
        });

        [TestMethod]
        public void EachEntryJoinsKindQuestStateValueAndTotalWithPipes()
        {
            var packet = Serializer.Serialize(new FmiPacket
            {
                Entries = new List<FmiSubPacket?>
                {
                    new() { Kind = FamilyQuestKind.Achievement, QuestId = 9018, State = FamilyQuestState.Completed, Value = 20261113 },
                    new() { Kind = FamilyQuestKind.Achievement, QuestId = 9037, State = FamilyQuestState.InProgress, Value = 7 },
                    new() { Kind = FamilyQuestKind.Mission, QuestId = 9004, State = FamilyQuestState.InProgress, Value = 3, TotalCompletions = 12 }
                }
            });

            Assert.AreEqual("fmi 1|9018|1|20261113|0 1|9037|2|7|0 0|9004|2|3|12", packet);
        }
    }
}
