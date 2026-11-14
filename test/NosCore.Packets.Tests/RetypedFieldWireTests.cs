//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Bazaar;
using NosCore.Packets.ClientPackets.Event;
using NosCore.Packets.ClientPackets.Families;
using NosCore.Packets.ClientPackets.Miniland;
using NosCore.Packets.ClientPackets.Parcel;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.Tests
{
    // The expected lines were produced by the serializer while these fields were still numbers,
    // so each test proves the enum writes and reads exactly the bytes the number did.
    [TestClass]
    public class RetypedFieldWireTests
    {
        private static readonly Serializer Serializer = new(new[]
        {
            typeof(RevivalPacket),
            typeof(JoinFamilyPacket),
            typeof(MLEditPacket),
            typeof(PstClientPacket),
            typeof(CRegPacket),
        });

        private static readonly Deserializer Deserializer = new(new[]
        {
            typeof(RevivalPacket),
            typeof(JoinFamilyPacket),
            typeof(MLEditPacket),
            typeof(PstClientPacket),
            typeof(CRegPacket),
        });

        [TestMethod]
        [DataRow(RevivalType.InPlace, "revival 0")]
        [DataRow(RevivalType.AtSavePoint, "revival 1")]
        [DataRow(RevivalType.InArena, "revival 2")]
        public void RevivalTypeKeepsItsWireValue(RevivalType type, string wire)
        {
            Assert.AreEqual(wire, Serializer.Serialize(new RevivalPacket { Type = type }));
            Assert.AreEqual(type, ((RevivalPacket)Deserializer.Deserialize(wire)).Type);
        }

        [TestMethod]
        [DataRow(FamilyInviteAnswerType.Accept, "gjoin 1 42")]
        [DataRow(FamilyInviteAnswerType.Decline, "gjoin 2 42")]
        public void FamilyInviteAnswerKeepsItsWireValue(FamilyInviteAnswerType type, string wire)
        {
            Assert.AreEqual(wire, Serializer.Serialize(new JoinFamilyPacket { Type = type, CharacterId = 42 }));
            Assert.AreEqual(type, ((JoinFamilyPacket)Deserializer.Deserialize(wire)).Type);
        }

        [TestMethod]
        public void MinilandIntroEditCarriesItsTextToTheEndOfTheLine()
        {
            const string wire = "mledit 1 Come in and rest";
            Assert.AreEqual(wire, Serializer.Serialize(new MLEditPacket { Type = MinilandEditType.Intro, Value = "Come in and rest" }));
            var packet = (MLEditPacket)Deserializer.Deserialize(wire);
            Assert.AreEqual(MinilandEditType.Intro, packet.Type);
            Assert.AreEqual("Come in and rest", packet.Introduction);
            Assert.IsNull(packet.State);
        }

        [TestMethod]
        public void MinilandStateEditKeepsItsWireValue()
        {
            const string wire = "mledit 2 1";
            Assert.AreEqual(wire, Serializer.Serialize(new MLEditPacket { Type = MinilandEditType.State, Value = "1" }));
            var packet = (MLEditPacket)Deserializer.Deserialize(wire);
            Assert.AreEqual(MinilandEditType.State, packet.Type);
            Assert.AreEqual(MinilandState.Private, packet.State);
            Assert.IsNull(packet.Introduction);
        }

        [TestMethod]
        [DataRow("7 mledit 2 2")]
        [DataRow("8 mledit 1 Come in and rest")]
        public void MinilandEditIsValidWhicheverViewIsEmpty(string wire)
        {
            var packet = (MLEditPacket)Deserializer.Deserialize(wire);
            Assert.IsTrue(packet.IsValid, string.Join("; ", packet.ValidationResult.Select(v => v.ErrorMessage)));
        }

        [TestMethod]
        public void MinilandStateEditWithAnUnknownStateHasNoState()
        {
            Assert.IsNull(((MLEditPacket)Deserializer.Deserialize("mledit 2 9")).State);
        }

        [TestMethod]
        [DataRow(PostActionType.Send, "pst 1 1 5 -1 0 Bob Title Hello^there")]
        [DataRow(PostActionType.Delete, "pst 2 1 5 -1 0 Bob Title Hello^there")]
        [DataRow(PostActionType.Read, "pst 3 1 5 -1 0 Bob Title Hello^there")]
        public void PostActionKeepsItsWireValue(PostActionType action, string wire)
        {
            Assert.AreEqual(wire, Serializer.Serialize(new PstClientPacket
            {
                ActionType = action, Type = 1, Id = 5, ReceiverName = "Bob", Title = "Title", Text = "Hello^there"
            }));
            Assert.AreEqual(action, ((PstClientPacket)Deserializer.Deserialize(wire)).ActionType);
        }

        [TestMethod]
        [DataRow(BazaarListingDuration.OneDay, "c_reg 0 1 3 0 0 1 0 2 500 25 0")]
        [DataRow(BazaarListingDuration.SevenDays, "c_reg 0 1 3 0 0 2 0 2 500 25 0")]
        [DataRow(BazaarListingDuration.FifteenDays, "c_reg 0 1 3 0 0 3 0 2 500 25 0")]
        [DataRow(BazaarListingDuration.ThirtyDays, "c_reg 0 1 3 0 0 4 0 2 500 25 0")]
        public void BazaarListingDurationKeepsItsWireValue(BazaarListingDuration durability, string wire)
        {
            Assert.AreEqual(wire, Serializer.Serialize(new CRegPacket
            {
                Inventory = 1, Slot = 3, Durability = durability, Amount = 2, Price = 500, Taxe = 25
            }));
            Assert.AreEqual(durability, ((CRegPacket)Deserializer.Deserialize(wire)).Durability);
        }
    }
}
