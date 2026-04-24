//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Chat;
using NosCore.Packets.ClientPackets.Families;
using NosCore.Packets.ClientPackets.Inventory;
using NosCore.Packets.ClientPackets.Relations;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Auction;
using NosCore.Packets.ServerPackets.Battle;
using NosCore.Packets.ServerPackets.CharacterSelectionScreen;
using NosCore.Packets.ServerPackets.Chats;
using NosCore.Packets.ServerPackets.Event;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Packets.ServerPackets.Login;
using NosCore.Packets.ServerPackets.Map;
using NosCore.Packets.ServerPackets.Mates;
using NosCore.Packets.ServerPackets.Miniland;
using NosCore.Packets.ServerPackets.MiniMap;
using NosCore.Packets.ServerPackets.Groups;
using NosCore.Packets.ServerPackets.Player;
using NosCore.Packets.ServerPackets.Quest;
using NosCore.Packets.ServerPackets.Quicklist;
using NosCore.Packets.ServerPackets.Relations;
using NosCore.Packets.ServerPackets.Shop;
using NosCore.Packets.ServerPackets.Specialists;
using NosCore.Packets.ServerPackets.UI;
using NosCore.Packets.ServerPackets.Visibility;
using NosCore.Shared.Enumerations;
using System.Collections.Generic;
using System.Linq;

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
                typeof(InvPacket),
                typeof(IvnPacket),
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
                typeof(TargetOffPacket),
                typeof(ScriptPacket),
                typeof(GuriPacket),
                typeof(BiPacket),
                typeof(MsgiPacket),
                typeof(SayiPacket),
                typeof(AtPacket),
                typeof(LevPacket),
                typeof(EventbPacket),
                typeof(ScPStcPacket),
                typeof(BfePacket),
                typeof(MallPacket),
                typeof(FtptPacket),
                typeof(ScpIndicatorPacket),
                typeof(EsfPacket),
                typeof(SopenPacket),
                typeof(StbmPacket),
                typeof(MinipetPacket),
                typeof(PetskiPacket),
                typeof(DpskiPacket),
                typeof(RaidopenPacket),
                typeof(CInfoResetPacket),
                typeof(EffTPacket),
                typeof(EffObPacket),
                typeof(RankCoolPacket),
                typeof(PetCool2Packet),
                typeof(CtlPacket),
                typeof(StpmPacket),
                typeof(ClinitPacket),
                typeof(FlinitPacket),
                typeof(KdlinitPacket),
                typeof(SkyinitPacket),
                typeof(StpPacket),
                typeof(Stp2Packet),
                typeof(TbfPacket),
                typeof(QrPacket),
                typeof(SqstPacket)
            });

        [TestMethod]
        public void AllPacketsAreSerializable()
        {
            var serializer = new Serializer(typeof(IPacket).Assembly.GetTypes()
                .Where(p => p.GetInterfaces().Contains(typeof(IPacket)) && p.IsClass && !p.IsAbstract).ToList());
            Assert.IsNotNull(serializer);
        }

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
        public void SerializePacketWithNullableOptionalInside()
        {
            var testPacket = new GuriPacket
            {
                Type = GuriPacketType.Dance,
                Argument = 1,
                EntityId = 2,
                SecondArgument = null,
                Value = null,
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("guri 2 1 2", packet);

            testPacket = new GuriPacket
            {
                Type = GuriPacketType.CharacterAnimation,
                Argument = 1,
                EntityId = 2,
                Value = 0,
                SecondValue = 0
            };

            packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("guri 6 1 2 0 0", packet);

            testPacket = new GuriPacket
            {
                Type = GuriPacketType.TextInput,
                Argument = 1,
                EntityId = 2,
                SecondArgument = 0,
            };

            packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("guri 10 1 0 2", packet);
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
        public void SerializeScriptPacketAdvance()
        {
            var testPacket = new ScriptPacket
            {
                ScriptId = 1,
                ScriptStepId = 80
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("script 1 80", packet);
        }

        [TestMethod]
        public void SerializeScriptPacketComplete()
        {
            var testPacket = new ScriptPacket
            {
                Unknown = 0,
                ScriptId = 1,
                ScriptStepId = 80
            };

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("script 0 1 80", packet);
        }

        [TestMethod]
        public void SerializeFlatQuestSubPacket()
        {
            var testPacket = new QstlistPacket(new List<QuestSubPacket>
            {
                new QuestSubPacket
                {
                    QuestSlot = 5,
                    QuestId = 1500,
                    QuestLineId = 1500,
                    QuestType = QuestType.Hunt,
                    Objective1Current = 0,
                    Objective1Required = 5,
                    QuestToShowInfo = true,
                }
            });

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("qstlist 5.1500.1500.1.0.5.0.0.0.0.0.0.0.0.0.1", packet);
        }

        [TestMethod]
        public void SerializeQuestSubPacketWithEmptyObjectives()
        {
            var testPacket = new QstlistPacket(new List<QuestSubPacket>
            {
                new QuestSubPacket
                {
                    QuestSlot = 0,
                    QuestId = 1997,
                    QuestLineId = 1997,
                    QuestType = QuestType.GoTo,
                    QuestToShowInfo = true,
                }
            });

            var packet = Serializer.Serialize(testPacket);
            Assert.AreEqual("qstlist 0.1997.1997.19.0.0.0.0.0.0.0.0.0.0.0.1", packet);
        }

        [TestMethod]
        public void NullableReferenceInferRequiredAttribute()
        {
            var testPacket = new QstlistPacket(null!);
            Assert.IsFalse(testPacket.IsValid);
            Assert.AreEqual("The QstlistPacket field is required.", testPacket.ValidationResult.Single().ErrorMessage);
        }

        [TestMethod]
        public void SerializeRecursiveSubPackets()
        {
            var testPacket =
                new QstiPacket(new QuestSubPacket
                {
                    QuestSlot = 5,
                    QuestId = 1500,
                    QuestLineId = 1500,
                    QuestType = QuestType.Hunt,
                    Objective1Current = 0,
                    Objective1Required = 5,
                    QuestToShowInfo = true,
                });

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
                    Type = DelayPacketType.Locomotion,
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
        public void SerializeWithPacketAsPropertyWithNullable()
        {
            var packet = Serializer.Serialize(
                    new DlgPacket
                    {
                        YesPacket = new BiPacket
                        {
                            PocketType = PocketType.Etc,
                            Slot = 1,
                            Option = RequestDeletionType.Requested
                        },
                        NoPacket = new BiPacket
                        {
                            PocketType = PocketType.Etc,
                            Slot = 1,
                            Option = RequestDeletionType.Declined
                        },
                        Question = "test"
                    });

            Assert.AreEqual($"dlg #b_i^2^1^1 #b_i^2^1^5 test", packet);
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
                RegionType = RegionType.EN,
            };
            var packet = Serializer.Serialize(nstestpacket);
            Assert.AreEqual("NsTeST 0 test 2 0 0 0 0 0 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 -99 0 1 -1:-1:-1:10000.10000.1", packet);
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
                Authority = AuthorityType.User,
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
            Assert.AreEqual("c_info test - -1 0 - 1 0 0 0 0 0 0 0 0 0 0 0 0 0 0", packet);
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
            Assert.AreEqual("in 3 - 0 0 0 0 0 0 0 0 0 -1 1 0 -1 - 2 -1 0 0 0 0 0 0 0 0 0 0 0", packet);
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
            Assert.AreEqual("in 2 - 0 0 0 0 0 0 0 0 0 -1 1 0 -1 - 2 -1 0 0 0 0 0 0 0 0 0 0 0", packet);
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
            Assert.AreEqual($"in 9 - {mapItem.VisualId} 0 0 {mapItem.InItemSubPacket.Amount} 0 0 0", packet);
        }

        [TestMethod]
        public void I18NargumentAreWellFormated()
        {
            var mapItem = new MsgiPacket
            {
                Type = MessageType.Center,
                Message = Game18NConstString.CurrentRemainingTime,
                Game18NArguments = { "test 123", 0 }
            };
            var packet = Serializer.Serialize(mapItem);
            Assert.AreEqual($"msgi 3 77 0 test 123 0 0 0", packet);
        }

        [TestMethod]
        public void I18NargumentAreWellFormatedWithLength()
        {
            var mapItem = new SayiPacket
            {
                Type = SayColorType.Blue,
                Message = Game18NConstString.IceBreakerWillStartForLevels,
                Game18NArguments = { 1, 2 }
            };
            var packet = Serializer.Serialize(mapItem);
            Assert.AreEqual($"sayi 0 0 6 363 0 1 2 0 0", packet);
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
                    Authority = AuthorityType.GameMaster,
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
                    FairyBooster = false,
                    FairyMorph = 0,
                    ShowInEffect = false,
                    Morph = 0,
                    WeaponUpgradeRareSubPacket = new UpgradeRareSubPacket(),
                    ArmorUpgradeRareSubPacket = new UpgradeRareSubPacket(),
                    FamilySubPacket = new FamilySubPacket(),
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
                    HeroLevel = 0,
                    Title = 0
                }
            };
            var packet = Serializer.Serialize(characterTest);
            Assert.AreEqual(
                $"in 1 characterTest - 0 0 0 0 {(byte)characterTest.InCharacterSubPacket.Authority} 0 0 0 0 -1.-1.-1.-1.-1.-1.-1.-1.-1.-1 0 0 0 -1 0 0 0 0 0 0 0 0 -1.-1 - 1 0 0 0 0 1 0 0|0|0 0 0 {(byte)characterTest.InCharacterSubPacket.Size} 0 0",
                packet);
        }

        [TestMethod]
        public void SerializeAtPacketMatchesTrace()
        {
            var p = new AtPacket
            {
                CharacterId = 116489,
                MapId = 1,
                PositionX = 76,
                PositionY = 114,
                Direction = 2,
                Unknown1 = 0,
                Music = 0,
                Unknown2 = 1,
                Unknown3 = -1,
                Unknown4 = 0,
                Unknown5 = 0
            };
            Assert.AreEqual("at 116489 1 76 114 2 0 0 1 -1 0 0", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeLevPacketMatchesTrace()
        {
            var p = new LevPacket
            {
                Level = 2,
                LevelXp = 60,
                JobLevel = 1,
                JobLevelXp = 720,
                XpLoad = 840,
                JobXpLoad = 2200,
                Reputation = 0,
                SkillCp = 2,
                HeroXp = 0,
                HeroLevel = 0,
                HeroXpLoad = 1,
                Unknown = 0
            };
            Assert.AreEqual("lev 2 60 1 720 840 2200 0 2 0 0 1 0", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeEventbPacketHasNoDuplicateIndices()
        {
            var p = new EventbPacket
            {
                SealedVesselEventIsActive = true,
                IncreaseExperienceEarned = 3,
                IncreaseGoldEarned = 7
            };
            var wire = Serializer.Serialize(p);
            Assert.AreEqual(28, wire.Split(' ').Length - 1);
            Assert.IsTrue(wire.StartsWith("evtb "));
            Assert.IsTrue(wire.Contains(" 1 3 7 "));
        }

        [TestMethod]
        public void SerializeScPStcPacketMatchesTrace()
        {
            var p = new ScPStcPacket { MaxMateCountTenths = 0, Unknown = 0 };
            Assert.AreEqual("sc_p_stc 0 0", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeBfePacketUsesUnderscoreHeader()
        {
            var p = new BfePacket
            {
                VisualType = VisualType.Player,
                VisualId = 11396565,
                CardId = 4002,
                Unknown = 0
            };
            Assert.AreEqual("bf_e 1 11396565 4002 0", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeMallPacketMatchesTrace()
        {
            Assert.AreEqual("mall 50", Serializer.Serialize(new MallPacket { State = 50 }));
        }

        [TestMethod]
        public void SerializeFtptPacketMatchesTrace()
        {
            Assert.AreEqual("ftpt -1", Serializer.Serialize(new FtptPacket { LeaderId = null }));
        }

        [TestMethod]
        public void SerializeScpIndicatorPacketMatchesTrace()
        {
            Assert.AreEqual("scp 1", Serializer.Serialize(new ScpIndicatorPacket { Value = 1 }));
        }

        [TestMethod]
        public void SerializeEsfPacketMatchesTrace()
        {
            Assert.AreEqual("esf 4", Serializer.Serialize(new EsfPacket { Value = 4 }));
        }

        [TestMethod]
        public void SerializeSopenPacketMatchesTrace()
        {
            Assert.AreEqual("sopen 1", Serializer.Serialize(new SopenPacket { Type = 1 }));
        }

        [TestMethod]
        public void SerializeStbmPacketMatchesTrace()
        {
            Assert.AreEqual("stbm -3", Serializer.Serialize(new StbmPacket { Value = -3 }));
        }

        [TestMethod]
        public void SerializeMinipetPacketMatchesTrace()
        {
            var p = new MinipetPacket { Type = 1, VisualId = 116489, MateTransportId = null };
            Assert.AreEqual("minipet 1 116489 -1", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializePetskiPacketMatchesTrace()
        {
            Assert.AreEqual(
                "petski 790 -1 -1",
                Serializer.Serialize(new PetskiPacket
                {
                    MateTransportId = 790,
                    FirstSkillVNum = -1,
                    SecondSkillVNum = -1,
                }));
        }

        [TestMethod]
        public void SerializeDpskiPacketMatchesTrace()
        {
            Assert.AreEqual("dpski 1", Serializer.Serialize(new DpskiPacket { State = 1 }));
        }

        [TestMethod]
        public void SerializeRaidopenPacketMatchesTrace()
        {
            Assert.AreEqual("raidopen", Serializer.Serialize(new RaidopenPacket()));
        }

        [TestMethod]
        public void SerializeCInfoResetPacketMatchesTrace()
        {
            Assert.AreEqual("c_info_reset", Serializer.Serialize(new CInfoResetPacket()));
        }

        [TestMethod]
        public void SerializeEffTPacketMatchesTrace()
        {
            var p = new EffTPacket
            {
                VisualType = VisualType.Npc,
                VisualId = 1095824,
                Unknown1 = 1,
                Unknown2 = 14267,
                Unknown3 = 4766
            };
            Assert.AreEqual("eff_t 2 1095824 1 14267 4766", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeEffObPacketMatchesTrace()
        {
            var p = new EffObPacket
            {
                ExtraSpace = string.Empty,
                MapX = -1,
                MapY = -1,
                Unknown = 0,
                EffectId = 4269
            };
            Assert.AreEqual("eff_ob  -1 -1 0 4269", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeRankCoolPacketMatchesTrace()
        {
            var p = new RankCoolPacket { Unknown1 = 0, Unknown2 = 0, Cooldown = 18000 };
            Assert.AreEqual("rank_cool 0 0 18000", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializePetCool2PacketMatchesTrace()
        {
            var p = new PetCool2Packet { ExtraSpace = string.Empty, Cooldown1 = 0, Cooldown2 = 0, Cooldown3 = 0 };
            Assert.AreEqual("pet_cool2  0 0 0", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeCtlPacketMatchesTrace()
        {
            var p = new CtlPacket { Type = 2, PetId = 1454169, Action = 3, Unknown = 0 };
            Assert.AreEqual("ctl 2 1454169 3 0", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeStpmPacketMatchesTrace()
        {
            var p = new StpmPacket();
            Assert.AreEqual("stpm 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeClinitPacketMatchesTrace()
        {
            var p = new ClinitPacket
            {
                SubPackets = new List<ClinitSubPacket?>
                {
                    new() { CharacterId = 14531, Level = 94, HeroLevel = 0, Compliment = 396, CharacterName = "Raizen°" },
                    new() { CharacterId = 3011, Level = 99, HeroLevel = 0, Compliment = 346, CharacterName = "Thanos" }
                }
            };
            Assert.AreEqual("clinit 14531|94|0|396|Raizen° 3011|99|0|346|Thanos", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeFlinitPacketMatchesTrace()
        {
            var p = new FlinitPacket
            {
                SubPackets = new List<FlinitSubPacket?>
                {
                    new() { CharacterId = 5177016, Level = 99, HeroLevel = 99, Reputation = 24862442, CharacterName = "Claw" }
                }
            };
            Assert.AreEqual("flinit 5177016|99|99|24862442|Claw", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeKdlinitPacketMatchesTrace()
        {
            var p = new KdlinitPacket
            {
                SubPackets = new List<KdlinitSubPacket?>
                {
                    new() { CharacterId = 26277, Level = 93, HeroLevel = 0, Act4Points = 261238, CharacterName = "______________" }
                }
            };
            Assert.AreEqual("kdlinit 26277|93|0|261238|______________", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeSkyinitPacketMatchesTrace()
        {
            var p = new SkyinitPacket
            {
                Type = 0,
                SubPackets = new List<SkyinitSubPacket?>
                {
                    new() { CharacterId = 9650, Level = 99, HeroLevel = 0, Points = 27332, CharacterName = "Gemstone" }
                }
            };
            Assert.AreEqual("skyinit 0 9650|99|0|27332|Gemstone", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeStpPacketMatchesTrace()
        {
            var p = new StpPacket
            {
                SubPackets = new List<StpSubPacket?>
                {
                    new() { SkillId = 0, Rank1 = 1, Rank2 = 1, Unknown = -1 },
                    new() { SkillId = 1, Rank1 = 1, Rank2 = 1, Unknown = -1 },
                    new() { SkillId = 2, Rank1 = 1, Rank2 = 1, Unknown = -1 }
                }
            };
            Assert.AreEqual("stp 0 1 1 -1 1 1 1 -1 2 1 1 -1", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeStp2PacketMatchesTrace()
        {
            var p = new Stp2Packet
            {
                SubPackets = new List<StpSubPacket?>
                {
                    new() { SkillId = 784, Rank1 = 3, Rank2 = 3, Unknown = -1 }
                }
            };
            Assert.AreEqual("stp2 784 3 3 -1", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeTbfPacketMatchesTrace()
        {
            var p = new TbfPacket
            {
                ExtraSpace = string.Empty,
                SubPackets = new List<TbfSubPacket?>
                {
                    new() { Major = 1, Minor = 0 },
                    new() { Major = 2, Minor = 0 },
                    new() { Major = 3, Minor = 0 },
                    new() { Major = 4, Minor = 0 },
                    new() { Major = 5, Minor = 0 }
                }
            };
            Assert.AreEqual("tbf  1.0 2.0 3.0 4.0 5.0", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeQrPacketMatchesTrace()
        {
            var p = new QrPacket
            {
                Type = 8,
                Unknown1 = 13,
                Unknown2 = 1,
                Unknown3 = 0,
                Unknown4 = 0,
                Unknown5 = 0,
                Unknown6 = 0,
                Unknown7 = 0,
                Unknown8 = 0,
                Unknown9 = 0,
                Unknown10 = 0,
                Unknown11 = 0,
                QuestId = 1500
            };
            Assert.AreEqual("qr 8 13 1 0 0 0 0 0 0 0 0 0 1500", Serializer.Serialize(p));
        }

        [TestMethod]
        public void SerializeSqstPacketMatchesTrace()
        {
            var p = new SqstPacket { ExtraSpace = string.Empty, Type = 0, Bitmap = "0000" };
            Assert.AreEqual("sqst  0 0000", Serializer.Serialize(p));
        }

        [TestMethod]
        [DataRow(PocketType.Mount, (byte)9)]
        [DataRow(PocketType.Raid, (byte)10)]
        public void SerializeInvPacketWithExtendedPocketTypesIsValid(PocketType type, byte expectedWireValue)
        {
            var packet = new InvPacket
            {
                Type = type,
                IvnSubPackets = new List<IvnSubPacket>()
            };

            Assert.IsTrue(packet.IsValid, string.Join("; ",
                packet.ValidationResult.Select(v => $"{string.Join(",", v.MemberNames)}: {v.ErrorMessage}")));
            Assert.AreEqual($"inv {expectedWireValue} ", Serializer.Serialize(packet));
        }

        [TestMethod]
        public void SerializeIvnPacketWithClearedSlotUsesZeroVNum()
        {
            var packet = new IvnPacket
            {
                Type = PocketType.Equipment,
                IvnSubPackets = new List<IvnSubPacket>
                {
                    new() { Slot = 19 }
                }
            };

            Assert.AreEqual("ivn 0 19.0.0.0.0.0.0", Serializer.Serialize(packet));
        }

        [TestMethod]
        public void SerializeIvnPacketWithPopulatedEquipmentSlotMatchesTrace()
        {
            var packet = new IvnPacket
            {
                Type = PocketType.Equipment,
                IvnSubPackets = new List<IvnSubPacket>
                {
                    new() { Slot = 20, VNum = 4998 }
                }
            };

            Assert.AreEqual("ivn 0 20.4998.0.0.0.0.0", Serializer.Serialize(packet));
        }

        [TestMethod]
        public void SerializeInPacketForItemPutsOwnerAfterUnknownZero()
        {
            var packet = new InPacket
            {
                VisualType = VisualType.Object,
                VNum = "1046",
                VisualId = 6467573,
                PositionX = 52,
                PositionY = 154,
                InItemSubPacket = new InItemSubPacket
                {
                    Amount = 10,
                    IsQuestRelative = false,
                    Unknown = 0,
                    Owner = 14643732
                }
            };

            Assert.AreEqual("in 9 1046 6467573 52 154 10 0 0 14643732", Serializer.Serialize(packet));
        }
    }
}