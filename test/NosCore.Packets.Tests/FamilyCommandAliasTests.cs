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
        public void TheClientWordForEachLanguageReachesTheFamilyCommand(string packet, Type expected)
        {
            Assert.IsInstanceOfType(Deserializer.Deserialize(packet), expected);
        }
    }
}
