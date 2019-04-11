using System.Collections.Concurrent;
using System.Collections.Generic;
using ChickenAPI.Packets.ClientPackets;
using ChickenAPI.Packets.ClientPackets.Chat;
using ChickenAPI.Packets.ClientPackets.Inventory;
using ChickenAPI.Packets.ClientPackets.Movement;
using ChickenAPI.Packets.ClientPackets.Shops;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;
using ChickenAPI.Packets.ServerPackets;
using ChickenAPI.Packets.ServerPackets.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
                typeof(StPacket)
            });

        [TestMethod]
        public void PacketEndingWithNullableMakeItOptional()
        {
            var packet = (WhisperPacket)Deserializer.Deserialize("/0Lucifer0 this is a long message", false);
            Assert.AreEqual("this is a long message", packet.Message);
        }

        [TestMethod]
        public void UnknownPacketAreUnresolved()
        {
            var packet = (UnresolvedPacket)Deserializer.Deserialize("unres 123", false);
            Assert.AreEqual("123", packet.Body);
            Assert.AreEqual("unres", packet.Header);
        }


        [TestMethod]
        public void PacketAreDeserializedWithHeaderAndKeepAliveId()
        {
            var packet = (WhisperPacket)Deserializer.Deserialize("1234 /0Lucifer0 this is a long message", true);
            Assert.AreEqual("this is a long message", packet.Message);
            Assert.AreEqual(1234, packet.KeepAliveId);
            Assert.AreEqual("/0Lucifer0", packet.Header);
        }


        [TestMethod]
        public void DeserializationLastStringCanNotBeNull()
        {
            var serializedPacket = (WhisperPacket)Deserializer.Deserialize("/0Lucifer0 ", false);
            Assert.AreEqual(serializedPacket.Message, "");
        }

        //[TestMethod]
        //public void PacketEndingWithNullableMakeItOptional()
        //{
        //    var packet = Deserializer.Deserialize("$CreateItem 1012 1", false);
        //    Assert.IsNotNull(packet);
        //}

        [TestMethod]
        public void DeserializeSpecial()
        {
            var packet = (UseItemPacket)Deserializer.Deserialize("u_i 2 3 4 5 6", false);
            Assert.IsTrue(packet.Mode == 6);
        }

        [TestMethod]
        public void DeserializeOptionalListPacket()
        {
            var packet = (MShopPacket)Deserializer.Deserialize("m_shop 1", false);
            Assert.IsTrue(packet.Type == CreateShopPacketType.Close);
        }

        [TestMethod]
        public void DeserializeListSubPacketWithoutSeparator()
        {
            var packet = (MShopPacket)Deserializer.Deserialize(
                "m_shop 0 0 20 1 2400 0 21 1 10692 2 0 8 2500 2 3 2 480 0 0 0 0 0 0 0 0 0 0 0 0 0 0" +
                " 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 admin Stand",
                false);
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
                "rest 1 2 3",
                false);
            Assert.IsTrue(packet.Amount == 1
                && packet.Users[0].VisualType == VisualType.Npc
                && packet.Users[0].VisualId == 3);
        }

        [TestMethod]
        public void DeserializeSimpleListWithoutSeparator()
        {
            var packet = (StPacket)Deserializer.Deserialize(
                "st 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16",
                false);
            Assert.IsTrue(packet.BuffIds.Count == 8);
        }
    }
}
