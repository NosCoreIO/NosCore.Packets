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
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class DeserializerTest
    {
        static readonly IDeserializer Deserializer = new Deserializer(
            new[] {
                typeof(NsTestPacket),
                typeof(NsTeStSubPacket),
                typeof(WorldCharacterCount),
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
                typeof(CBListPacket),
                typeof(CScalcPacket),
                typeof(CreateFamilyPacket),
                typeof(UnresolvedPacket)
            });

        [TestMethod]
        public void AllPacketsAreDeserializable()
        {
            var deserializer = new Deserializer(typeof(IPacket).Assembly.GetTypes()
                .Where(p => p.GetInterfaces().Contains(typeof(IPacket)) && p.IsClass && !p.IsAbstract).ToList());
            Assert.IsNotNull(deserializer);
        }

        [TestMethod]
        public void UnresolvedPacketsAreValid()
        {
            var packet = (UnresolvedPacket)Deserializer.Deserialize("unresolved");
            Assert.IsTrue(packet.IsValid);
        }

        [TestMethod]
        public void PacketCBListTest()
        {
            var packet = (CBListPacket)Deserializer.Deserialize("c_blist  0 0 0 0 0 0 0 0 0");
            Assert.AreEqual(0, packet.Index);
            Assert.IsNull(packet.ItemVNumFilter);
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
            var packet = (NsTestPacket)Deserializer.Deserialize("NsTeST 4 gorlik 2 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 1 3 2 2 7 1 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 31135 79.110.84.132:4016:1:1.7.Feniks 79.110.84.132:4014:1:1.5.Feniks 79.110.84.132:4015:0:1.6.Feniks 79.110.84.132:4011:7:1.2.Feniks 79.110.84.132:4012:1:1.3.Feniks 79.110.84.132:4013:1:1.4.Feniks 79.110.84.132:4010:1:1.1.Feniks -1:-1:-1:10000.10000.1");
            Assert.AreEqual("gorlik", packet.AccountName);
            Assert.HasCount(8, packet.SubPacket!);
        }

        [TestMethod]
        public void PacketEndingWithStringMakeItSerializedToEnd()
        {
            var packet = (WhisperPacket)Deserializer.Deserialize("/0Lucifer0 this is a long message");
            Assert.AreEqual("0Lucifer0 this is a long message", packet.Message);
        }


        [TestMethod]
        public void PacketEndingWithParenthesisShouldDeserialize()
        {
            var packet = (WhisperPacket)Deserializer.Deserialize("/0Lucifer0 this is a long (message)");
            Assert.AreEqual("0Lucifer0 this is a long (message)", packet.Message);
        }

        [TestMethod]
        public void PacketEndingWithCaretShouldDeserialize()
        {
            var packet = (WhisperPacket)Deserializer.Deserialize("/0Lucifer0 this is a long (message)^");
            Assert.AreEqual("0Lucifer0 this is a long (message)^", packet.Message);
        }

        [TestMethod]
        public void PacketEndingWithDotShouldDeserialize()
        {
            var packet = (WhisperPacket)Deserializer.Deserialize("/0Lucifer0 this is a long .");
            Assert.AreEqual("0Lucifer0 this is a long .", packet.Message);
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
            var serializedPacket = (FamilyChatPacket)Deserializer.Deserialize(":");
            Assert.AreEqual("", serializedPacket.Message);
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
            Assert.AreEqual(VisualType.Map, packet.VisualType);
            Assert.AreEqual(1, packet.VisualId);
            Assert.AreEqual(2, packet.FamilyId);
            Assert.AreEqual("familyname", packet.FamilyName);
            Assert.AreEqual("customrank", packet.FamilyCustomRank);
            Assert.AreEqual(3, packet.FamilyLevel);
            Assert.AreEqual(3, packet.FamilyIcons.Count(s => s));
            Assert.AreEqual(1, packet.FamilyIcons.Count(s => !s));
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
            Assert.AreEqual(6, packet.Mode);
        }

        [TestMethod]
        public void DeserializeSpecialWithKeepalive()
        {
            var packet = (UseItemPacket)Deserializer.Deserialize("12345 u_i 2 3 4 5 6");
            Assert.AreEqual(6, packet.Mode);
        }

        [TestMethod]
        public void DeserializeOptionalListPacket()
        {
            var packet = (MShopPacket)Deserializer.Deserialize("m_shop 1");
            Assert.AreEqual(CreateShopPacketType.Close, packet.Type);
        }

        [TestMethod]
        public void DeserializeListSubPacketWithoutSeparator()
        {
            var packet = (MShopPacket)Deserializer.Deserialize(
                "m_shop 0 0 20 1 2400 0 21 1 10692 2 0 8 2500 2 3 2 480 0 0 0 0 0 0 0 0 0 0 0 0 0 0" +
                " 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 admin Stand"
                );
            Assert.AreEqual<byte>(0, packet.Type);
            Assert.AreEqual<byte>(0, packet.ItemList![1]!.Type);
            Assert.AreEqual(21, packet.ItemList[1]!.Slot);
            Assert.AreEqual(1, packet.ItemList[1]!.Amount);
            Assert.AreEqual(10692, packet.ItemList[1]!.Price);
            Assert.AreEqual("admin Stand", packet.Name);
        }

        [TestMethod]
        public void DeserializeistSubPacketWithoutSeparator()
        {
            var packet = (SitPacket)Deserializer.Deserialize(
                "rest 1 2 3"
                );
            Assert.AreEqual(1, packet.Amount);
            Assert.AreEqual(VisualType.Npc, packet.Users![0]!.VisualType);
            Assert.AreEqual(3, packet.Users[0]!.VisualId);
        }

        [TestMethod]
        public void DeserializeSimpleListWithoutSpaceSeparator()
        {
            var packet = (StPacket)Deserializer.Deserialize(
                "st 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16"
                );
            Assert.HasCount(8, packet.BuffIds!);
        }

        [TestMethod]
        public void DeserializeSpecialPacket()
        {
            var packet = (FinsPacket)Deserializer.Deserialize(
                "#fins^1^2"
            );
            Assert.AreEqual(FinsPacketType.Accepted, packet.Type);
            Assert.AreEqual(2, packet.CharacterId);
        }

        [TestMethod]
        public void DeserializeSpecialPacketAndKeepaliveId()
        {
            var packet = (FinsPacket)Deserializer.Deserialize(
                "123 #fins^1^2"
            );
            Assert.AreEqual(FinsPacketType.Accepted, packet.Type);
            Assert.AreEqual(2, packet.CharacterId);
        }

        [TestMethod]
        public void DeserializeSpecialPacketSubpacket()
        {
            var packet = (FinfoPacket)Deserializer.Deserialize(
                "finfo 2.1.Friend1 3.0.Friend2"
            );
            Assert.HasCount(2, packet.FriendList!);
            Assert.AreEqual(2, packet.FriendList!.First()!.CharacterId);
            Assert.IsTrue(packet.FriendList!.First()!.IsConnected);
            Assert.AreEqual("Friend1", packet.FriendList!.First()!.CharacterName);
            Assert.AreEqual(3, packet.FriendList!.Skip(1).First()!.CharacterId);
            Assert.IsFalse(packet.FriendList!.Skip(1).First()!.IsConnected);
            Assert.AreEqual("Friend2", packet.FriendList!.Skip(1).First()!.CharacterName);
        }

        [TestMethod]
        public void DeserializeListWithAmountIndex()
        {
            var packet = (SitPacket)Deserializer.Deserialize(
                "rest 2 1 5 1 4"
            );
            Assert.HasCount(2, packet.Users!);
            Assert.AreEqual(VisualType.Player, packet.Users!.First()!.VisualType);
            Assert.AreEqual(5, packet.Users!.First()!.VisualId);
            Assert.AreEqual(VisualType.Player, packet.Users!.Skip(1).First()!.VisualType);
            Assert.AreEqual(4, packet.Users!.Skip(1).First()!.VisualId);
        }

        [TestMethod]
        public void DeserializeInjectedSpecialPacket()
        {
            var packet = (DlgPacket)Deserializer.Deserialize(
                "dlg #fins^1^2 #fins^2^2 test"
            );
            Assert.AreEqual(FinsPacketType.Accepted, ((FinsPacket)packet.YesPacket!).Type);
            Assert.AreEqual(2, ((FinsPacket)packet.YesPacket!).CharacterId);
            Assert.AreEqual(FinsPacketType.Rejected, ((FinsPacket)packet.NoPacket!).Type);
            Assert.AreEqual(2, ((FinsPacket)packet.NoPacket).CharacterId);
            Assert.AreEqual("test", packet.Question);
        }


        [TestMethod]
        public void DeserializeNullStringPacket()
        {
            var packet = (CreateFamilyPacket)Deserializer.Deserialize(
                "glmk"
            );
            Assert.IsNull(packet.FamilyName);
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
            Assert.AreEqual(NrunRunnerType.ChangeClass, packet.Runner);
        }

        [TestMethod]
        public void DeserializeWithDoubleSpace()
        {
            var packet = (NoS0577Packet)Deserializer.Deserialize(
                "NoS0577 37633936363633662D633332352D346461612D383933612D373031346639653063646463  c437f3f4-06cb-405d-b3c8-73e5c7772c80 0034F3E8 00.9.3.3123 0 BC4AE02D9759A1C83532D7B5C861D2D2"
            );
            Assert.AreEqual("NoS0577", packet.Header);
            Assert.AreEqual("37633936363633662D633332352D346461612D383933612D373031346639653063646463", packet.AuthToken);
            Assert.AreEqual(Guid.Parse("c437f3f4-06cb-405d-b3c8-73e5c7772c80"), packet.ClientId);
            Assert.AreEqual("0034F3E8", packet.UnknownYet);
            Assert.AreEqual(0, packet.ClientVersion!.Major);
            Assert.AreEqual(9, packet.ClientVersion.Minor);
            Assert.AreEqual(3, packet.ClientVersion.Fix);
            Assert.AreEqual(RegionType.EN, packet.RegionType);
            Assert.AreEqual(3123, packet.ClientVersion.SubFix);
            Assert.AreEqual(0, packet.UnknownConstant);
            Assert.AreEqual("BC4AE02D9759A1C83532D7B5C861D2D2", packet.Md5String);
        }

        [TestMethod]
        public void DeserializeWithGuid()
        {
            var packet = (NoS0575Packet)Deserializer.Deserialize(
                "NoS0575 1468578 admin EE26B0DD4AF7E749AA1A8EE3C10AE9923F618980772E473F8819A5D4940E0DB27AC185F8A0E1D5F84F88BC887FD67B143732C304CC5FA9AD8E6F57F50028A8FF c437f3f4-06cb-405d-b3c8-73e5c7772c80 006548C6 00.9.3.3125 0 458E0876581FA9A6EFE00A28AA8E75F2"
                );
            Assert.AreEqual("NoS0575", packet.Header);
            Assert.AreEqual(1468578, packet.SessionId);
            Assert.AreEqual("admin", packet.Username);
            Assert.AreEqual("EE26B0DD4AF7E749AA1A8EE3C10AE9923F618980772E473F8819A5D4940E0DB27AC185F8A0E1D5F84F88BC887FD67B143732C304CC5FA9AD8E6F57F50028A8FF", packet.Password);
            Assert.AreEqual(Guid.Parse("c437f3f4-06cb-405d-b3c8-73e5c7772c80"), packet.ClientId);
            Assert.AreEqual("006548C6", packet.UnknownYet);
            Assert.AreEqual(0, packet.Unknown2);
            Assert.AreEqual(0, packet.ClientVersion!.Major);
            Assert.AreEqual(9, packet.ClientVersion.Minor);
            Assert.AreEqual(3, packet.ClientVersion.Fix);
            Assert.AreEqual(3125, packet.ClientVersion.SubFix);
            Assert.AreEqual(RegionType.EN, packet.RegionType);
            Assert.AreEqual("458E0876581FA9A6EFE00A28AA8E75F2", packet.Md5String);
        }
    }
}
