//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using NosCore.Packets.ClientPackets.Chat;
using NosCore.Packets.ClientPackets.Families;
using NosCore.Packets.ClientPackets.Inventory;
using NosCore.Packets.ClientPackets.Relations;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Auction;
using NosCore.Packets.ServerPackets.Chats;
using NosCore.Packets.ServerPackets.Event;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Packets.ServerPackets.Login;
using NosCore.Packets.ServerPackets.Miniland;
using NosCore.Packets.ServerPackets.Player;
using NosCore.Packets.ServerPackets.Quicklist;
using NosCore.Packets.ServerPackets.Relations;
using NosCore.Packets.ServerPackets.Shop;
using NosCore.Packets.ServerPackets.UI;
using NosCore.Packets.ServerPackets.Visibility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ServerPackets.CharacterSelectionScreen;
using NosCore.Packets.ServerPackets.Quest;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class SerializationTests
    {
        static readonly ISerializer Serializer = new Serializer(
            new[]
            {
                typeof(ClistPacket),
                typeof(QstlistPacket),
                typeof(QstiPacket),
                typeof(SayItemPacket),
                typeof(MloInfoPacket),
                typeof(NInvPacket),
                typeof(QSlotPacket),
                typeof(RcbListPacket),
                typeof(DelayPacket),
                typeof(UseItemPacket),
                typeof(DlgPacket),
                typeof(WhisperPacket),
                typeof(InPacket),
                typeof(BlinitPacket),
                typeof(NsTestPacket),
                typeof(FinsPacket),
                typeof(GidxPacket),
                typeof(CInfoPacket),
                typeof(RbrPacket),
                typeof(MlobjlstPacket),
                typeof(SuccessPacket),
                typeof(TargetOffPacket)
            });

        [TestMethod]
        public void SerializePacketWithNullableOptional()
        {
            var testPacket = new NInvPacket
            {
                Items = new List<NInvItemSubPacket?>
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
            Assert.AreEqual("n_inv 0 0 0 0.0.0.-1.0", packet);
        }

        [TestMethod]
        public void SerializePacketWithNonPacketListNonSplitted()
        {
            var testPacket = new ClistPacket
            {
                Name = "test",
                Equipments = new List<short?>() { null, null, null, null, null, null, null, null, null, null },
                Pets = new List<short?>() { null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null },
                Rename = true
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("clist 0 test 0 0 0 0 0 0 0 0 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1 0  0 0 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1.-1 0 1", packet);
        }


        [TestMethod]
        public void SerializeInheritedPacket()
        {
            var testPacket = new TargetOffPacket
            {
                QuestId = 1997,
                TargetX = 57,
                TargetY = 149,
                TargetMap = 1
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("targetoff 57 149 1 1997", packet);
        }

        [TestMethod]
        public void SerializeRecursiveListSubPackets()
        {
            var testPacket = new QstlistPacket()
            {
                QuestSubPackets = new List<QuestSubPacket>
                {
                    new QuestSubPacket {
                        ObjectiveCount = 5,
                        QuestId = 1500,
                        InfoId = 1500,
                        GoalType = QuestType.Hunt,
                        QuestObjectiveSubPackets = new List<QuestObjectiveSubPacket>()
                           {
                               new QuestObjectiveSubPacket
                               {
                                   CurrentCount = 0,
                                   IsFinished = false,
                                   MaxCount = 5
                               }
                               , new QuestObjectiveSubPacket()
                               , new QuestObjectiveSubPacket()
                               , new QuestObjectiveSubPacket()
                               , new QuestObjectiveSubPacket()
                           },
                        ShowDialog = true
                    }
                }
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("qstlist 5.1500.1500.1.0.5.0.0.0.0.0.0.0.0.0.1", packet);
        }

        [TestMethod]
        public void SerializeRecursiveSubPackets()
        {
            var testPacket =
                new QstiPacket()
                {
                    QuestSubPacket = new QuestSubPacket()
                    {
                        ObjectiveCount = 5,
                        QuestId = 1500,
                        InfoId = 1500,
                        GoalType = QuestType.Hunt,
                        QuestObjectiveSubPackets = new List<QuestObjectiveSubPacket>()
                    {
                        new QuestObjectiveSubPacket
                        {
                            CurrentCount = 0,
                            IsFinished = false,
                            MaxCount = 5
                        },
                        new QuestObjectiveSubPacket(), new QuestObjectiveSubPacket(), new QuestObjectiveSubPacket(),
                        new QuestObjectiveSubPacket()
                    },
                        ShowDialog = true
                    }
                };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("qsti 5.1500.1500.1.0.5.0.0.0.0.0.0.0.0.0.1", packet);
        }

        [TestMethod]
        public void SerializePacketWithNoParameters()
        {
            var testPacket = new SuccessPacket();

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("success", packet);
        }

        [TestMethod]
        public void SerializePacketWithCaretSpecialSeparator()
        {
            var testPacket = new MlobjlstPacket
            {
                MlobjlstSubPacket = new List<MlobjlstSubPacket?>
                {
                    new MlobjlstSubPacket()
                    {
                        MlObjSubPacket = new MlobjSubPacket()
                    },  new MlobjlstSubPacket()
                    {
                        MlObjSubPacket = new MlobjSubPacket()
                    }
                }
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("mlobjlst 0.0.0.0.0.0.0.0.0.0 0.0.0.0.0.0.0.0.0.0", packet);
        }

        [TestMethod]
        public void SerializePacketWithReturnSplitter()
        {
            var testPacket = new RbrPacket
            {
                TsBasicInfo = new RbrSubPacketBasicInfo(),
                BonusRewards = new List<RbrSubPacketItem?> { new RbrSubPacketItem(), new RbrSubPacketItem(), new RbrSubPacketItem() },
                Completed = true,
                DrawRewards = new List<RbrSubPacketItem?> { new RbrSubPacketItem(), new RbrSubPacketItem(), new RbrSubPacketItem(), new RbrSubPacketItem(), new RbrSubPacketItem() },
                HighScore = new RbrSubPacketHighScore(),
                SpecialRewards = new List<RbrSubPacketItem?> { new RbrSubPacketItem(), new RbrSubPacketItem() },
                RequiredSeeds = 1,
                MinMaxLevel = new RbrSubPacketMinMaxLevel { MinLevel = 1, MaxLevel = 99 },
                Unknown = 0,
                TitleAndDescription = new RbrSubPacketTitleAndDescription
                {
                    Description = "this is a test",
                    Title = "this is another test"
                }
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("rbr 0.0.0 0 1 1 99 1 -1.0 -1.0 -1.0 -1.0 -1.0 -1.0 -1.0 -1.0 -1.0 -1.0 0 0 0 this is another test\nthis is a test", packet);
        }


        [TestMethod]
        public void SerializeWithRemoveHeader()
        {

            var packet = Serializer.Serialize(
                new RcbListPacket
                {
                    PageIndex = 1,
                    Items = new List<RcbListPacket.RcbListElementPacket?>
                   {
                       new RcbListPacket.RcbListElementPacket
                       {
                            AuctionId = 1,
                            OwnerId = 2,
                            OwnerName = "test",
                            ItemId = 3,
                            Amount = 4,
                            IsPackage=false,
                            Price = 6,
                            MinutesLeft =7,
                            Unknown1 = false,
                            Unknown = 9,
                            Rarity = 10 ,
                            Upgrade = 11,
                            EInfo = new EInfoPacket()
                        },
                       new RcbListPacket.RcbListElementPacket
                       {
                           AuctionId = 1,
                           OwnerId = 2,
                           OwnerName = "test",
                           ItemId = 3,
                           Amount = 4,
                           IsPackage=false,
                           Price = 6,
                           MinutesLeft =7,
                           Unknown1 = false,
                           Unknown = 9,
                           Rarity = 10 ,
                           Upgrade = 11,
                           EInfo = new EInfoPacket()
                       }
                   }
                }
            );
            Assert.AreEqual($"rc_blist 1 1|2|test|3|4|0|6|7|0|9|10|11|0^0^0^0^0 1|2|test|3|4|0|6|7|0|9|10|11|0^0^0^0^0", packet);
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
        public void SerializeWithMultiplePacketAsProperty()
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
        public void SerializeWithNoSpecialHeader()
        {
            var dlgTest = new SayItemPacket
            {
                Message = "<SPEAKER>[Username]:{item}",
                OratorSlot = 17,
                EquipmentInfo = null,
                VisualId = 1,
                VisualType = VisualType.Player,
                IconInfo = new IconInfoPacket
                {
                    IconId = 1012
                }
            };

            var packet = Serializer.Serialize(dlgTest);
            Assert.AreEqual(
                "sayitem 1 1 17 <SPEAKER>[Username]:{item} IconInfo 1012",
                packet);
        }

        [TestMethod]
        public void SerializeWithNullFirstParam()
        {
            var dlgTest = new QSlotPacket
            {
                Slot = 0,
                Data = new List<QsetClientSubPacket?>
                {
                    new QsetClientSubPacket
                    {
                        OriginQuickList = 7,
                        OriginQuickListSlot = 7,
                        Data = -1
                    },
                     new QsetClientSubPacket
                    {
                        OriginQuickList = 7,
                        OriginQuickListSlot = 7,
                        Data = -1
                    }
                }
            };

            var packet = Serializer.Serialize(dlgTest);
            Assert.AreEqual(
                "qslot 0 7.7.-1 7.7.-1",
                packet);
        }

        [TestMethod]
        public void SerializeWithSpecialSeparator()
        {
            var dlgTest = new BlinitPacket
            {
                SubPackets = new List<BlinitSubPacket?>
                {
                    new BlinitSubPacket { RelatedCharacterId = 1, CharacterName = "test" },
                    new BlinitSubPacket { RelatedCharacterId = 2, CharacterName = "test2" }
                }
            };

            var packet = Serializer.Serialize(dlgTest);
            Assert.AreEqual(
                "blinit 1|test 2|test2",
                packet);
        }

        [TestMethod]
        public void SerializeWithSizedArray()
        {
            var mloInfoPacket = new MloInfoPacket
            {
                IsOwner = false,
                ObjectVNum = 0,
                Slot = 0,
                MinilandPoints = 0,
                LawDurability = false,
                IsFull = false,
                MinigamePoints = new MloInfoPacketSubPacket[5]
                {
                    new MloInfoPacketSubPacket(),
                    new MloInfoPacketSubPacket(),
                    new MloInfoPacketSubPacket(),
                    new MloInfoPacketSubPacket(),
                    new MloInfoPacketSubPacket(),
                }
            };

            var packet = Serializer.Serialize(mloInfoPacket);
            Assert.AreEqual(
                "mlo_info 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0",
                packet);
        }

        [TestMethod]
        public void SerializeWithOneSpecialAndOneDefaultSeparator()
        {
            var subpacket = new List<NsTeStSubPacket?>
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
                SessionId = 1,
                RegionType = RegionType.EN
            };
            var packet = Serializer.Serialize(nstestpacket);
            Assert.AreEqual("NsTeST 0 test 1 -1:-1:-1:10000.10000.1", packet);
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
        public void SerializePacketWithStringNullReplaceByDash()
        {
            var packet = Serializer.Serialize(new CInfoPacket()
            {
                Name = "test",
                Unknown1 = null,
                GroupId = -1,
                FamilyId = 0,
                FamilyName = null,
                CharacterId = 1,
                Authority = AuthorityUIType.User,
                Gender = GenderType.Male,
                HairStyle = HairStyleType.HairStyleA,
                HairColor = HairColorType.DarkPurple,
                Class = CharacterClassType.Adventurer,
                Icon = 0,
                Compliment = 0,
                Morph = 0,
                Invisible = false,
                FamilyLevel = 0,
                MorphUpgrade = 0,
                ArenaWinner = false

            });
            Assert.AreEqual("c_info test - -1 0 - 1 0 0 0 0 0 0 0 0 0 0 0 0", packet);
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
                Items = new List<NInvItemSubPacket?>()
                {
                    new NInvItemSubPacket()
                    {
                        Type = PocketType.Equipment,
                        Slot = 0,
                        VNum = 0,
                        RareAmount = 0,
                        UpgradeDesign = 0,
                        Price = 1
                    },
                    null,
                    new NInvItemSubPacket()
                    {
                        Type = PocketType.Equipment,
                        Slot = 2,
                        VNum = 0,
                        RareAmount = 0,
                        UpgradeDesign = 0,
                        Price = 1
                    }
                }
            });
            Assert.AreEqual("n_inv 1 0 0 0 0.0.0.0.0.1 -1 0.2.0.0.0.1", packet);
        }

        [TestMethod]
        public void GenerateInPacketIsNotCorruptedForMonster()
        {
            var mapMonsterPacket = new InPacket
            {
                VisualType = VisualType.Monster,
                Name = null,
                VisualId = 0,
                VNum = null,
                PositionX = 0,
                PositionY = 0,
                Direction = 0,
                InNonPlayerSubPacket = new InNonPlayerSubPacket
                {
                    Dialog = 0,
                    InAliveSubPacket = new InAliveSubPacket
                    {
                        Mp = 0,
                        Hp = 0
                    },
                    IsSitting = false,
                    SpawnEffect = SpawnEffectType.NoEffect,
                    Unknow1 = 2
                }
            };
            var packet = Serializer.Serialize(mapMonsterPacket);
            Assert.AreEqual("in 3 - 0 0 0 0 0 0 0 0 0 -1 1 0 -1 - 2 -1 0 0 0 0 0 0 0 0", packet);
        }

        [TestMethod]
        public void GenerateInPacketIsNotCorruptedForNpc()
        {
            var mapNpcPacket = new InPacket
            {
                VisualType = VisualType.Npc,
                Name = null,
                VisualId = 0,
                VNum = null,
                PositionX = 0,
                PositionY = 0,
                Direction = 0,
                InNonPlayerSubPacket = new InNonPlayerSubPacket
                {
                    Dialog = 0,
                    InAliveSubPacket = new InAliveSubPacket
                    {
                        Mp = 0,
                        Hp = 0
                    },
                    IsSitting = false,
                    SpawnEffect = SpawnEffectType.NoEffect,
                    Unknow1 = 2
                }
            };
            var packet = Serializer.Serialize(mapNpcPacket);
            Assert.AreEqual("in 2 - 0 0 0 0 0 0 0 0 0 -1 1 0 -1 - 2 -1 0 0 0 0 0 0 0 0", packet);
        }


        [TestMethod]
        public void GenerateInPacketIsNotCorruptedForItem()
        {
            var mapItem = new InPacket
            {
                VisualType = VisualType.Object,
                VisualId = 1,
                VNum = null,
                PositionX = 0,
                PositionY = 0,
                InItemSubPacket = new InItemSubPacket
                {
                    Amount = 25,
                    IsQuestRelative = false,
                    Owner = 0
                }
            };
            var packet = Serializer.Serialize(mapItem);
            Assert.AreEqual($"in 9 - {mapItem.VisualId} 0 0 {mapItem.InItemSubPacket.Amount} 0 0", packet);
        }

        [TestMethod]
        public void GenerateGidxPacketIsNotCorrupted()
        {
            var characterTest = new GidxPacket
            {
                VisualType = VisualType.Player,
                VisualId = 1,
                FamilyId = 1337,
                FamilyName = "FAMILY_NAME",
                FamilyCustomRank = "NONE",
                FamilyLevel = 10,
                FamilyIcons = new List<bool> { false, false, false }
            };
            var packet = Serializer.Serialize(characterTest);
            Assert.AreEqual(
                $"gidx 1 1 1337 FAMILY_NAME NONE 10 0|0|0",
                packet);
        }


        [TestMethod]
        public void GenerateInPacketIsNotCorruptedForCharacter()
        {
            var characterTest = new InPacket
            {
                VisualType = VisualType.Player,
                Name = "characterTest",
                VNum = null,
                VisualId = 0,
                PositionX = 0,
                PositionY = 0,
                Direction = 0,
                InCharacterSubPacket = new InCharacterSubPacket
                {
                    Authority = AuthorityUIType.GameMaster,
                    Gender = 0,
                    HairStyle = 0,
                    HairColor = 0,
                    Class = CharacterClassType.Adventurer,
                    Equipment = new InEquipmentSubPacket(),
                    InAliveSubPacket = new InAliveSubPacket
                    {
                        Hp = 0,
                        Mp = 0
                    },
                    IsSitting = false,
                    GroupId = null,
                    Fairy = 0,
                    FairyElement = 0,
                    Unknown = 0,
                    Morph = 0,
                    Unknown2 = 0,
                    Unknown3 = 0,
                    WeaponUpgradeRareSubPacket = new UpgradeRareSubPacket(),
                    ArmorUpgradeRareSubPacket = new UpgradeRareSubPacket(),
                    FamilyId = -1,
                    FamilyName = null,
                    ReputIco = 1,
                    Invisible = false,
                    MorphUpgrade = 0,
                    Faction = 0,
                    MorphUpgrade2 = 0,
                    Level = 1,
                    FamilyLevel = 0,
                    ArenaWinner = false,
                    FamilyIcons = new List<bool> { false, false, false },
                    Compliment = 0,
                    Size = 10,
                    HeroLevel = 0
                }
            };
            var packet = Serializer.Serialize(characterTest);
            Assert.AreEqual(
                $"in 1 characterTest - 0 0 0 0 {(byte)characterTest.InCharacterSubPacket.Authority} 0 0 0 0 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1 0 0 0 -1 0 0 0 0 0 0 0 0 -1 - 1 0 0 0 0 1 0 0|0|0 0 0 {(byte)characterTest.InCharacterSubPacket.Size} 0",
                packet);
        }
    }
}