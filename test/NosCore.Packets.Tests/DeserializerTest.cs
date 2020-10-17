//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.ClientPackets.Chat;
using NosCore.Packets.ClientPackets.Inventory;
using NosCore.Packets.ClientPackets.Login;
using NosCore.Packets.ClientPackets.Movement;
using NosCore.Packets.ClientPackets.Shops;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NosCore.Packets.ClientPackets.Battle;
using NosCore.Packets.ClientPackets.Families;
using NosCore.Packets.ClientPackets.Npcs;
using NosCore.Packets.ClientPackets.Relations;
using NosCore.Packets.ServerPackets.UI;
using System.Linq;
using NosCore.Packets.ServerPackets.Relations;
using NosCore.Packets.ClientPackets.Bazaar;
using NosCore.Packets.ClientPackets.Commands;
using NosCore.Packets.ClientPackets.Warehouse;
using NosCore.Packets.ServerPackets.CharacterSelectionScreen;
using NosCore.Packets.ServerPackets.Login;
using NosCore.Packets.ServerPackets.Miniland;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class DeserializerTest
    {
        static readonly IDeserializer Deserializer = new Deserializer(
            new[] {
                typeof(ClistPacket),
                typeof(MinilandInvitePacket),
                typeof(WhisperPacket),
                typeof(UseItemPacket),
                typeof(MShopPacket),
                typeof(SitPacket),
                typeof(SitSubPacket),
                typeof(MShopItemSubPacket),
                typeof(StPacket),
                typeof(NoS0575Packet),
                typeof(NoS0577Packet),
                typeof(FamilyChatPacket),
                typeof(FStashEndPacket),
                typeof(RequestNpcPacket),
                typeof(NrunPacket),
                typeof(NcifPacket),
                typeof(FinsPacket),
                typeof(DlgPacket),
                typeof(GidxPacket),
                typeof(FinfoPacket),
                typeof(FinfoSubPackets),
                typeof(ClientVersionSubPacket),
                typeof(CScalcPacket),
                typeof(NsTestPacket),
                typeof(NsTeStSubPacket),
            });

        [TestMethod]
        public void AllPacketsAreDeserializable()
        {
            var deserializer = new Deserializer(typeof(IPacket).Assembly.GetTypes()
                .Where(p => p.GetInterfaces().Contains(typeof(IPacket)) && p.IsClass && !p.IsAbstract).ToList());
            Assert.IsTrue(deserializer != null);
        }

        [TestMethod]
        public void PacketClistTest()
        {
            var packet = (ClistPacket)Deserializer.Deserialize("clist 0 gorlik 0 1 0 9 0 0 1 0 -1.12.1.8.-1.-1.-1.-1.-1.-1 1  1 1 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1. 0 0");
            Assert.AreEqual("gorlik", packet.Name);
        }

        [TestMethod]
        public void PacketNsTestLogin()
        {
            var packet = (NsTestPacket)Deserializer.Deserialize("NsTeST 4 gorlik 2 31135 79.110.84.132:4016:1:1.7.Feniks 79.110.84.132:4014:1:1.5.Feniks 79.110.84.132:4015:0:1.6.Feniks 79.110.84.132:4011:7:1.2.Feniks 79.110.84.132:4012:1:1.3.Feniks 79.110.84.132:4013:1:1.4.Feniks 79.110.84.132:4010:1:1.1.Feniks -1:-1:-1:10000.10000.1");
            Assert.AreEqual("gorlik", packet.AccountName);
            Assert.AreEqual(8, packet.SubPacket!.Count);
        }

        [TestMethod]
        public void PacketEndingWithStringMakeItSerializedToEnd()
        {
            var packet = (WhisperPacket)Deserializer.Deserialize("/0Lucifer0 this is a long message");
            Assert.AreEqual("0Lucifer0 this is a long message", packet.Message);
        }

        [TestMethod]
        public void UnknownPacketAreUnresolved()
        {
            var packet = (UnresolvedPacket)Deserializer.Deserialize("unres 123");
            Assert.AreEqual("123", packet.Body);
            Assert.AreEqual("unres", packet.Header);
        }

        [TestMethod]
        public void PacketWithoutPropertiesAreDeserialized()
        {
            var packet = (FStashEndPacket)Deserializer.Deserialize("f_stash_end");
            Assert.AreEqual("f_stash_end", packet.Header);
        }

        [TestMethod]
        public void UnknownPacketAreUnresolvedWithoutBody()
        {
            var packet = (UnresolvedPacket)Deserializer.Deserialize("1234 0");
            Assert.AreEqual("", packet.Body);
            Assert.AreEqual("0", packet.Header);
            Assert.AreEqual((ushort)1234, packet.KeepAliveId);
        }

        [TestMethod]
        public void PacketWithAliasCanBeDeserialized()
        {
            var packet = (MinilandInvitePacket)Deserializer.Deserialize("$Inviter test");
            Assert.AreEqual("test", packet.CharacterName);
        }

        [TestMethod]
        public void PacketAreDeserializedWithHeaderAndKeepAliveId()
        {
            var packet = (WhisperPacket)Deserializer.Deserialize("1234 /0Lucifer0 this is a long message");
            Assert.AreEqual("0Lucifer0 this is a long message", packet.Message);
            Assert.AreEqual((ushort)1234, packet.KeepAliveId);
            Assert.AreEqual("/", packet.Header);
        }


        [TestMethod]
        public void DeserializationLastStringCanNotBeNull()
        {
            var serializedPacket = (FamilyChatPacket)Deserializer.Deserialize(": ");
            Assert.AreEqual(serializedPacket.Message, "");
        }

        [TestMethod]
        public void PacketEndingWithNullableMakeItOptional()
        {
            var packet = Deserializer.Deserialize("npc_req 2 2075");
            Assert.IsNotNull(packet);
            Assert.IsFalse(packet is UnresolvedPacket);
        }

        [TestMethod]
        public void DeserializeListSeparator()
        {
            var packet = (GidxPacket)Deserializer.Deserialize("gidx 0 1 2 familyname customrank 3 1|1|1|0");
            Assert.IsTrue(packet.VisualType == VisualType.Map);
            Assert.IsTrue(packet.VisualId == 1);
            Assert.IsTrue(packet.FamilyId == 2);
            Assert.IsTrue(packet.FamilyName == "familyname");
            Assert.IsTrue(packet.FamilyCustomRank == "customrank");
            Assert.IsTrue(packet.FamilyLevel == 3);
            Assert.IsTrue(packet.FamilyIcons.Count(s => s) == 3);
            Assert.IsTrue(packet.FamilyIcons.Count(s => !s) == 1);
        }

        [TestMethod]
        public void PacketEndingWithNullableMakeItOptionalWithKeepalive()
        {
            var packet = Deserializer.Deserialize("12345 npc_req 2");
            Assert.IsNotNull(packet);
            Assert.IsFalse(packet is UnresolvedPacket);
        }

        [TestMethod]
        public void DeserializeSpecial()
        {
            var packet = (UseItemPacket)Deserializer.Deserialize("u_i 2 3 4 5 6");
            Assert.IsTrue(packet.Mode == 6);
        }

        [TestMethod]
        public void DeserializeSpecialWithKeepalive()
        {
            var packet = (UseItemPacket)Deserializer.Deserialize("12345 u_i 2 3 4 5 6");
            Assert.IsTrue(packet.Mode == 6);
        }

        [TestMethod]
        public void DeserializeOptionalListPacket()
        {
            var packet = (MShopPacket)Deserializer.Deserialize("m_shop 1");
            Assert.IsTrue(packet.Type == CreateShopPacketType.Close);
        }

        [TestMethod]
        public void DeserializeListSubPacketWithoutSeparator()
        {
            var packet = (MShopPacket)Deserializer.Deserialize(
                "m_shop 0 0 20 1 2400 0 21 1 10692 2 0 8 2500 2 3 2 480 0 0 0 0 0 0 0 0 0 0 0 0 0 0" +
                " 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 admin Stand"
                );
            Assert.IsTrue(packet.Type == 0
                && packet.ItemList![1]!.Type == 0
                && packet.ItemList[1]!.Slot == 21
                && packet.ItemList[1]!.Amount == 1
                && packet.ItemList[1]!.Price == 10692
                && packet.Name == "admin Stand");
        }

        [TestMethod]
        public void DeserializeistSubPacketWithoutSeparator()
        {
            var packet = (SitPacket)Deserializer.Deserialize(
                "rest 1 2 3"
                );
            Assert.IsTrue(packet.Amount == 1
                && packet.Users![0]!.VisualType == VisualType.Npc
                && packet.Users[0]!.VisualId == 3);
        }

        [TestMethod]
        public void DeserializeSimpleListWithoutSpaceSeparator()
        {
            var packet = (StPacket)Deserializer.Deserialize(
                "st 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16"
                );
            Assert.IsTrue(packet.BuffIds!.Count == 8);
        }

        [TestMethod]
        public void DeserializeSpecialPacket()
        {
            var packet = (FinsPacket)Deserializer.Deserialize(
                "#fins^1^2"
            );
            Assert.IsTrue(packet.Type == FinsPacketType.Accepted);
            Assert.IsTrue(packet.CharacterId == 2);
        }

        [TestMethod]
        public void DeserializeSpecialPacketAndKeepaliveId()
        {
            var packet = (FinsPacket)Deserializer.Deserialize(
                "123 #fins^1^2"
            );
            Assert.IsTrue(packet.Type == FinsPacketType.Accepted);
            Assert.IsTrue(packet.CharacterId == 2);
        }

        [TestMethod]
        public void DeserializeSpecialPacketSubpacket()
        {
            var packet = (FinfoPacket)Deserializer.Deserialize(
                "finfo 2.1.Friend1 3.0.Friend2"
            );
            Assert.IsTrue(packet.FriendList!.Count == 2);
            Assert.IsTrue(packet.FriendList.First()!.CharacterId == 2);
            Assert.IsTrue(packet.FriendList.First()!.IsConnected);
            Assert.IsTrue(packet.FriendList.First()!.CharacterName == "Friend1");
            Assert.IsTrue(packet.FriendList.Skip(1).First()!.CharacterId == 3);
            Assert.IsFalse(packet.FriendList.Skip(1).First()!.IsConnected);
            Assert.IsTrue(packet.FriendList.Skip(1).First()!.CharacterName == "Friend2");
        }

        [TestMethod]
        public void DeserializeListWithAmountIndex()
        {
            var packet = (SitPacket)Deserializer.Deserialize(
                "rest 2 1 5 1 4"
            );
            Assert.IsTrue(packet.Users!.Count == 2);
            Assert.IsTrue(packet.Users.First()!.VisualType == VisualType.Player);
            Assert.IsTrue(packet.Users.First()!.VisualId == 5);
            Assert.IsTrue(packet.Users.Skip(1).First()!.VisualType == VisualType.Player);
            Assert.IsTrue(packet.Users.Skip(1).First()!.VisualId == 4);
        }

        [TestMethod]
        public void DeserializeInjectedSpecialPacket()
        {
            var packet = (DlgPacket)Deserializer.Deserialize(
                "dlg #fins^1^2 #fins^2^2 test"
            );
            Assert.IsTrue(((FinsPacket)packet.YesPacket!).Type == FinsPacketType.Accepted);
            Assert.IsTrue(((FinsPacket)packet.YesPacket!).CharacterId == 2);
            Assert.IsTrue(((FinsPacket)packet.NoPacket!).Type == FinsPacketType.Rejected);
            Assert.IsTrue(((FinsPacket)packet.NoPacket).CharacterId == 2);
            Assert.IsTrue(packet.Question == "test");
        }

        [TestMethod]
        public void DeserializeInvalidValidationIsNotValidAndValidationResultIsFilled()
        {
            var packet = (CScalcPacket)Deserializer.Deserialize("c_scalc 11 1012 -1 99 10");
            Assert.IsNotNull(packet.ValidationResult);
            Assert.IsFalse(packet.IsValid);
        }

        [TestMethod]
        public void DeserializeInvalidValidationIsNotValid()
        {
            var packet = (NcifPacket)Deserializer.Deserialize("ncif 1 -10");
            Assert.IsFalse(packet.IsValid);
        }

        [TestMethod]
        public void DeserializeValidValidationIsValid()
        {
            var packet = (NcifPacket)Deserializer.Deserialize("ncif 1 1");
            Assert.IsTrue(packet.IsValid);
        }

        [TestMethod]
        public void DeserializeInvalidEnumIsNotValid()
        {
            var packet = (NcifPacket)Deserializer.Deserialize("ncif 5 1");
            Assert.IsFalse(packet.IsValid);
        }

        [TestMethod]
        public void DeserializeNullableEnum()
        {
            var packet = (NrunPacket)Deserializer.Deserialize(
                "n_run 1"
            );
            Assert.IsTrue(packet.Runner == NrunRunnerType.ChangeClass);
        }

        [TestMethod]
        public void DeserializeWithDoubleSpace()
        {
            var packet = (NoS0577Packet)Deserializer.Deserialize(
                "NoS0577 37633936363633662D633332352D346461612D383933612D373031346639653063646463  c437f3f4-06cb-405d-b3c8-73e5c7772c80 0034F3E8 00.9.3.3123 0 BC4AE02D9759A1C83532D7B5C861D2D2"
            );
            Assert.IsTrue(packet.Header == "NoS0577");
            Assert.IsTrue(packet.AuthToken == "37633936363633662D633332352D346461612D383933612D373031346639653063646463");
            Assert.IsTrue(packet.ClientId == Guid.Parse("c437f3f4-06cb-405d-b3c8-73e5c7772c80"));
            Assert.IsTrue(packet.UnknownYet == "0034F3E8");
            Assert.IsTrue(packet.ClientVersion!.Major == 0);
            Assert.IsTrue(packet.ClientVersion.Minor == 9);
            Assert.IsTrue(packet.ClientVersion.Fix == 3);
            Assert.IsTrue(packet.RegionType == RegionType.EN);
            Assert.IsTrue(packet.ClientVersion.SubFix == 3123);
            Assert.IsTrue(packet.UnknownConstant == 0);
            Assert.IsTrue(packet.Md5String == "BC4AE02D9759A1C83532D7B5C861D2D2");
        }

        [TestMethod]
        public void DeserializeWithGuid()
        {
            var packet = (NoS0575Packet)Deserializer.Deserialize(
                "NoS0575 1468578 admin EE26B0DD4AF7E749AA1A8EE3C10AE9923F618980772E473F8819A5D4940E0DB27AC185F8A0E1D5F84F88BC887FD67B143732C304CC5FA9AD8E6F57F50028A8FF c437f3f4-06cb-405d-b3c8-73e5c7772c80 006548C6 00.9.3.3125 0 458E0876581FA9A6EFE00A28AA8E75F2"
                );
            Assert.IsTrue(packet.Header == "NoS0575");
            Assert.IsTrue(packet.SessionId == 1468578);
            Assert.IsTrue(packet.Username == "admin");
            Assert.IsTrue(packet.Password == "EE26B0DD4AF7E749AA1A8EE3C10AE9923F618980772E473F8819A5D4940E0DB27AC185F8A0E1D5F84F88BC887FD67B143732C304CC5FA9AD8E6F57F50028A8FF");
            Assert.IsTrue(packet.ClientId == Guid.Parse("c437f3f4-06cb-405d-b3c8-73e5c7772c80"));
            Assert.IsTrue(packet.UnknownYet == "006548C6");
            Assert.IsTrue(packet.Unknown2 == 0);
            Assert.IsTrue(packet.ClientVersion!.Major == 0);
            Assert.IsTrue(packet.ClientVersion.Minor == 9);
            Assert.IsTrue(packet.ClientVersion.Fix == 3);
            Assert.IsTrue(packet.ClientVersion.SubFix == 3125);
            Assert.IsTrue(packet.RegionType == RegionType.EN);
            Assert.IsTrue(packet.Md5String == "458E0876581FA9A6EFE00A28AA8E75F2");
        }
    }
}
