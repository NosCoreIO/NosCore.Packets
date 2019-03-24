using System.Collections.Concurrent;
using System.Collections.Generic;
using ChickenAPI.Packets.ClientPackets;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;
using ChickenAPI.Packets.ServerPackets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChickenAPI.Packets.Tests
{
    [TestClass]
    public class SerializationTests
    {
        static ISerializer Serializer = new Serializer(
            new[] {
                typeof(DelayPacket),
                typeof(UseItemPacket),
                typeof(NInvPacket),
                typeof(DlgPacket),
                typeof(WhisperPacket),
                typeof(InPacket),
                typeof(BlinitPacket),
                typeof(NsTestPacket),
                typeof(FinsPacket)
            });

        [TestMethod]
        public void SerializePacketWithNullableOptional()
        {
            var testPacket = new NInvPacket
            {
                Items = new List<NInvItemSubPacket>
                {
                    new NInvItemSubPacket
                    {
                        Type = 0,
                        Slot = 0,
                        Price = 0,
                        RareAmount = null,
                        UpgradeDesign = null,
                        VNum = 0
                    }
                }
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("n_inv 0 0 0 0 0.0.0.-1.0", packet);
        }

        [TestMethod]
        public void SerializeWithPacketAsProperty()
        {
            var packet = Serializer.Serialize(
                new DelayPacket
                {
                    Type = 3,
                    Delay = 3000,
                    Packet = new UseItemPacket()
                    {
                        VisualType = VisualType.Player,
                        VisualId = 0,
                        Type = PocketType.Main,
                        Slot = 1,
                        Mode = 2,
                        Parameter = 0,
                    }
                }
            );
            Assert.AreEqual($"delay 3000 3 #u_i^1^0^1^1^2^0", packet);
        }

        [TestMethod]
        public void serializeWithMultiplePacketAsProperty()
        {
            var dlgTest = new DlgPacket
            {
                Question = "question",
                NoPacket = new FinsPacket { Type = FinsPacketType.Rejected, CharacterId = 1 },
                YesPacket = new FinsPacket { Type = FinsPacketType.Accepted, CharacterId = 1 }
            };

            var packet = Serializer.Serialize(dlgTest);
            Assert.AreEqual(
                "dlg #fins^1^1 #fins^2^1 question",
                packet);
        }



        [TestMethod]
        public void SerializeWithSpecialSeparator()
        {
            var dlgTest = new BlinitPacket
            {
                SubPackets = new List<BlinitSubPacket>
                {
                    new BlinitSubPacket {RelatedCharacterId = 1, CharacterName = "test"},
                    new BlinitSubPacket {RelatedCharacterId = 2, CharacterName = "test2"}
                }
            };

            var packet = Serializer.Serialize(dlgTest);
            Assert.AreEqual(
                "blinit 1|test 2|test2",
                packet);
        }

        [TestMethod]
        public void SerializeWithOneSpecialAndOneDefaultSeparator()
        {
            var subpacket = new List<NsTeStSubPacket>
            {
                new NsTeStSubPacket
                {
                    Host = "-1",
                    Port = null,
                    Color = null,
                    WorldCount = 10000,
                    WorldId = 10000,
                    Name = "1"
                }
            };
            var nstestpacket = new NsTestPacket
            {
                AccountName = "test",
                SubPacket = subpacket,
                SessionId = 1
            };
            var packet = Serializer.Serialize(nstestpacket);
            Assert.AreEqual("NsTeST test 1 -1:-1:-1:10000.10000.1", packet);
        }

        [TestMethod]
        public void SerializeLastIndexStringIsNotSlit()
        {
            var packet = Serializer.Serialize(new WhisperPacket
            {
                Message = "test message !"
            });
            Assert.AreEqual("/ test message !", packet);
        }

        [TestMethod]
        public void SerializeListContainNullItem()
        {
            var packet = Serializer.Serialize(new NInvPacket()
            {
                VisualType = VisualType.Player,
                VisualId = 0,
                Unknown = 0,
                ShopKind = 0,
                Items = new List<NInvItemSubPacket>()
                {
                    new NInvItemSubPacket()
                    {
                        Type = PocketType.Equipment,
                        Slot = 0,
                        VNum = 0,
                        RareAmount = 0,
                        UpgradeDesign = 0,
                        Price = 0
                    },
                    null,
                    new NInvItemSubPacket()
                    {
                        Type = PocketType.Equipment,
                        Slot = 2,
                        VNum = 0,
                        RareAmount = 0,
                        UpgradeDesign = 0,
                        Price = 0
                    }
                }
            });
            Assert.AreEqual("n_inv 1 0 0 0 0.0.0.0.0.1 -1 0.2.0.0.0.1", packet);
        }

        [TestMethod]
        public void GenerateInPacketIsNotCorruptedForMonster()
        {
            var mapMonsterPacket = new InPacket();//TODO craft this packet
            var packet = Serializer.Serialize(mapMonsterPacket);
            Assert.AreEqual("in 3 - 0 0 0 0 0 0 0 0 0 -1 1 0 -1 - 2 -1 0 0 0 0 0 0 0 0", packet);
        }

        [TestMethod]
        public void GenerateInPacketIsNotCorruptedForNpc()
        {
            var mapNpcPacket = new InPacket();//TODO craft this packet
            var packet = Serializer.Serialize(mapNpcPacket);
            Assert.AreEqual("in 2 - 0 0 0 0 0 0 0 0 0 -1 1 0 -1 - 2 -1 0 0 0 0 0 0 0 0", packet);
        }


        [TestMethod]
        public void GenerateInPacketIsNotCorruptedForItem()
        {
            var mapItem = new InPacket();//TODO craft this packet
            var packet = Serializer.Serialize(mapItem);
            Assert.AreEqual($"in 9 - {mapItem.VisualId} 0 0 {mapItem.InItemSubPacket.Amount} 0 0", packet);
        }


        [TestMethod]
        public void GenerateInPacketIsNotCorruptedForCharacter()
        {
            var characterTest = new InPacket();//TODO craft this packet
            var packet = Serializer.Serialize(characterTest);
            Assert.AreEqual(
                $"in 1 characterTest - 0 0 0 0 {(byte)characterTest.InCharacterSubPacket.Authority} 0 0 0 0 -1.-1.-1.-1.-1.-1.-1.-1.-1 0 0 0 -1 0 0 0 0 0 0 00 00 -1 - 1 0 0 0 0 1 0 0 0 {(byte)characterTest.InCharacterSubPacket.Size} 0",
                packet);
        }
    }
}
