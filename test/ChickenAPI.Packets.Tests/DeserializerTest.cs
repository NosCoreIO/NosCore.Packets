using ChickenAPI.Packets.ClientPackets.Chat;
using ChickenAPI.Packets.ClientPackets.Inventory;
using ChickenAPI.Packets.ClientPackets.Login;
using ChickenAPI.Packets.ClientPackets.Movement;
using ChickenAPI.Packets.ClientPackets.Shops;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;
using ChickenAPI.Packets.ServerPackets.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChickenAPI.Packets.ClientPackets.Battle;
using ChickenAPI.Packets.ClientPackets.Families;
using ChickenAPI.Packets.ClientPackets.Npcs;

namespace ChickenAPI.Packets.Tests
{
    [TestClass]
    public class DeserializerTest
    {
        static IDeserializer Deserializer = new Deserializer(
            new[] {
                typeof(WhisperPacket),
                typeof(UseItemPacket),
                typeof(MShopPacket),
                typeof(SitPacket),
                typeof(SitSubPacket),
                typeof(MShopItemSubPacket),
                typeof(StPacket),
                typeof(NoS0575Packet),
                typeof(FamilyChatPacket),
                typeof(FStashEndPacket),
                typeof(RequestNpcPacket),
                typeof(NrunPacket),
                typeof(NcifPacket)
            });

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
                && packet.ItemList[1].Type == 0
                && packet.ItemList[1].Slot == 21
                && packet.ItemList[1].Amount == 1
                && packet.ItemList[1].Price == 10692
                && packet.Name == "admin Stand");
        }

        [TestMethod]
        public void DeserializeistSubPacketWithoutSeparator()
        {
            var packet = (SitPacket)Deserializer.Deserialize(
                "rest 1 2 3"
                );
            Assert.IsTrue(packet.Amount == 1
                && packet.Users[0].VisualType == VisualType.Npc
                && packet.Users[0].VisualId == 3);
        }

        [TestMethod]
        public void DeserializeSimpleListWithoutSeparator()
        {
            var packet = (StPacket)Deserializer.Deserialize(
                "st 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16"
                );
            Assert.IsTrue(packet.BuffIds.Count == 8);
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
        public void DeserializeNullableEnum()
        {
            var packet = (NrunPacket)Deserializer.Deserialize(
                "n_run 1"
            );
            Assert.IsTrue(packet.Runner == NrunRunnerType.ChangeClass);
        }

        [TestMethod]
        public void DeserializeWithGuid()
        {
            var packet = (NoS0575Packet)Deserializer.Deserialize(
                "NoS0575 3808647 admin EE26B0DD4AF7E749AA1A8EE3C10AE9923F618980772E473F8819A5D4940E0DB27AC185F8A0E1D5F84F88BC887FD67B143732C304CC5FA9AD8E6F57F50028A8FF 3e241e8e-b1cd-49c3-a455-4d253a75f6e6 0031F69F�0.9.3.3097 0 06A35F0058610A5B3FA13FC2CB04E795"
                );
            Assert.IsTrue(packet.Header == "NoS0575");
            Assert.IsTrue(packet.Number == 3808647);
            Assert.IsTrue(packet.Name == "admin");
            Assert.IsTrue(packet.Password == "EE26B0DD4AF7E749AA1A8EE3C10AE9923F618980772E473F8819A5D4940E0DB27AC185F8A0E1D5F84F88BC887FD67B143732C304CC5FA9AD8E6F57F50028A8FF");
            Assert.IsTrue(packet.ClientId == Guid.Parse("3e241e8e-b1cd-49c3-a455-4d253a75f6e6"));
            Assert.IsTrue(packet.ClientData == "0031F69F�0.9.3.3097 0 06A35F0058610A5B3FA13FC2CB04E795");
        }
    }
}
