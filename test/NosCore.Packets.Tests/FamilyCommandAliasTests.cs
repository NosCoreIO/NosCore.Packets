//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Commands;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class FamilyCommandAliasTests
    {
        private static readonly Deserializer Deserializer = new(new[]
        {
            typeof(FamilyHeadPacket),
            typeof(FamilyDeputyPacket),
            typeof(FamilyKeeperPacket),
            typeof(FamilyInvitePacket),
            typeof(FamilyLeavePacket),
            typeof(FamilyShoutPacket),
            typeof(FamilyDismissPacket),
            typeof(FamilyNoticePacket),
            typeof(FamilyTodayPacket),
            typeof(FamilyTitlePacket),
            typeof(FamilyGenderPacket),
        });

        [TestMethod]
        [DataRow("%Têtedefamille Buddy", typeof(FamilyHeadPacket))]
        [DataRow("%Capofamiglia Buddy", typeof(FamilyHeadPacket))]
        [DataRow("%Szef Buddy", typeof(FamilyHeadPacket))]
        [DataRow("%Ailereisi Buddy", typeof(FamilyHeadPacket))]
        [DataRow("%Familienvertreter Buddy", typeof(FamilyDeputyPacket))]
        [DataRow("%Ailetemsilcisi Buddy", typeof(FamilyDeputyPacket))]
        [DataRow("%Zarządca Buddy", typeof(FamilyKeeperPacket))]
        [DataRow("%Aileyöneticisi Buddy", typeof(FamilyKeeperPacket))]
        [DataRow("%Invitationdefamille Buddy", typeof(FamilyInvitePacket))]
        [DataRow("%Ailedaveti Buddy", typeof(FamilyInvitePacket))]
        [DataRow("%Congédefamille", typeof(FamilyLeavePacket))]
        [DataRow("%Esci", typeof(FamilyLeavePacket))]
        [DataRow("%Ailedençıkış", typeof(FamilyLeavePacket))]
        [DataRow("%Grido hello", typeof(FamilyShoutPacket))]
        [DataRow("%Aileçağrısı hello", typeof(FamilyShoutPacket))]
        [DataRow("%Caccia Buddy", typeof(FamilyDismissPacket))]
        [DataRow("%Ailedenatılma Buddy", typeof(FamilyDismissPacket))]
        [DataRow("%Familydismiss Buddy", typeof(FamilyDismissPacket))]
        [DataRow("%Avertissement hello", typeof(FamilyNoticePacket))]
        [DataRow("%Not hello", typeof(FamilyNoticePacket))]
        [DataRow("%Aujourd'hui hello", typeof(FamilyTodayPacket))]
        [DataRow("%Bugün hello", typeof(FamilyTodayPacket))]
        [DataRow("%Titre Buddy 2", typeof(FamilyTitlePacket))]
        [DataRow("%Tytuł Buddy 2", typeof(FamilyTitlePacket))]
        [DataRow("%Sexe 1", typeof(FamilyGenderPacket))]
        [DataRow("%Pohlaví 1", typeof(FamilyGenderPacket))]
        public void TheClientWordForEachLanguageReachesTheFamilyCommand(string packet, Type expected)
        {
            Assert.IsInstanceOfType(Deserializer.Deserialize(packet), expected);
        }
    

        [TestMethod]
        public void TheFamilyNoticeKeepsEveryWord()
        {
            var packet = (FamilyNoticePacket)Deserializer.Deserialize("%Notice meet at the bank tonight");
            Assert.AreEqual("meet at the bank tonight", packet.Message);
        }

        [TestMethod]
        public void TheTitleCarriesTheMemberAndTheRank()
        {
            var packet = (FamilyTitlePacket)Deserializer.Deserialize("%Title Buddy 2");
            Assert.AreEqual("Buddy", packet.CharacterName);
            Assert.AreEqual((Enumerations.FamilyMemberRank)2, packet.Rank);
        }

        [TestMethod]
        public void TheGenderIsReadAsAGender()
        {
            var packet = (FamilyGenderPacket)Deserializer.Deserialize("%Gender 1");
            Assert.AreEqual(Enumerations.GenderType.Female, packet.Gender);
        }
    }
}
