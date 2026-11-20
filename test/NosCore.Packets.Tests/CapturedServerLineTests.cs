//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ClientPackets.Inventory;
using NosCore.Packets.ClientPackets.Npcs;
using NosCore.Packets.ServerPackets.Battle;
using NosCore.Packets.ServerPackets.Entities;
using NosCore.Packets.ServerPackets.Event;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Packets.ServerPackets.Mates;
using NosCore.Packets.ServerPackets.MiniMap;
using NosCore.Packets.ServerPackets.Player;
using NosCore.Packets.ServerPackets.Quicklist;
using NosCore.Packets.ServerPackets.Quest;
using NosCore.Packets.ServerPackets.TimeSpaces;
using NosCore.Packets.ServerPackets.UI;
using NosCore.Packets.ServerPackets.Visibility;
using NosCore.Packets.ServerPackets.Warehouse;
using NosCore.Shared.Enumerations;
using System;
using System.Linq;
using System.Reflection;

namespace NosCore.Packets.Tests
{
    // Server lines taken from packet traces of the live game, read the way a client reads them.
    [TestClass]
    public class CapturedServerLineTests
    {
        private static readonly ISerializer Serializer = new Serializer(PacketCorpus.SerializableTypes.ToList());

        private static readonly IDeserializer Deserializer = new Deserializer(PacketCorpus.SerializableTypes.Where(type =>
            type.Namespace?.Contains(".ClientPackets", StringComparison.Ordinal) != true
            || type.GetCustomAttribute<PacketHeaderAttribute>() == null
            || type == typeof(ClientPackets.Inventory.UseItemPacket)));

        [TestMethod]
        [DataRow("qslot 0 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1")]
        [DataRow("qslot 1 1.1.0 1.1.1 1.1.2 1.1.3 1.1.4 1.1.5 1.1.10 1.1.9 1.1.8 1.1.7 1.1.6 7.-1.-1 7.-1.-1 7.-1.-1 1.3.1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 0.1.5 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 0.1.-1")]
        [DataRow("qset 1 7 0.1.5.0")]
        [DataRow("guri 8 8")]
        [DataRow("guri 2 1 7700921 0")]
        [DataRow("guri 6 1 11834056 0 0")]
        [DataRow("guri 4 0 15")]
        [DataRow("rsfm 628 2 0 0 0")]
        [DataRow("rsfm 33 0 5 11 0")]
        [DataRow("c_mode 1 14293841 13 10 5 0 100 0")]
        [DataRow("c_mode 2 7560447 2310 0 0")]
        [DataRow("c_mode 3 5118 462 0 0")]
        [DataRow("c_info Anonymous - -1 -1 - 9999999 0 1 0 9 3 -2 0 0 0 0 0 0 0 -1")]
        [DataRow("c_info Anonymous - -1 999.999 FAnonymous 9999999 0 0 2 46 2 27 0 21 0 15 14 0 0 12")]
        [DataRow("repay  -1.0.0 -1.0.0 -1.0.0 -1.0.0 -1.0.0 -1.0.0")]
        [DataRow("repay  2028.0.5 -1.0.0 -1.0.0 -1.0.0 -1.0.0 -1.0.0")]
        [DataRow("exts 0 48 48 84 0")]
        [DataRow("delay 5000 7 #u_i^1^14882169^2^2^4")]
        [DataRow("dlgi #u_i^1^14882169^2^2^1 #u_i^1^14882169^2^2^2 1813 0 0")]
        [DataRow("rp 3 153 199 #u_i^1^14882169^2^3^1")]
        [DataRow("rnsc 0")]
        [DataRow("rnsc 628")]
        [DataRow("mapclear")]
        [DataRow("s_mode 1 14293841 13 0")]
        [DataRow("nowtime  13 40 30")]
        [DataRow("psr 2")]
        [DataRow("gmapr 7297521 2")]
        [DataRow("qnpc 331|1|19 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1")]
        [DataRow("qnpc -1|1|19 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1")]
        [DataRow("guri 2 1 14882169 0")]
        [DataRow("guri 2 2 1659263 0")]
        [DataRow("guri 16 2 5922210")]
        [DataRow("wp 45 173 6 1 15 99")]
        [DataRow("wp 45 173 6 0 15 99")]
        [DataRow("msgi 6 2298 10 361 5 0 0")]
        [DataRow("msgi 9 2302 0 0 0 0 0")]
        [DataRow("bsinfo 2 1 0 0")]
        [DataRow("bsinfo 2 4 0 0")]
        [DataRow("bsinfo 2 99 0 0")]
        [DataRow("eq 14639620 0 1 11 15 2 8795.8645.4620.4628.4610.8674.8884.8886.8869.8888.8880 97 87 100")]
        [DataRow("rsfm 4 1 6 12 0")]
        [DataRow("rsfm 33 2 0 0 0")]
        [DataRow("eff_ob  -1 -1 0 4269")]
        [DataRow("stbm -4")]
        [DataRow("stbm 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0")]
        [DataRow("stbm 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0")]
        [DataRow("su 1 14608437 3 3040 -1 0 15 -1 -1 -1 1 1 0 -1 0")]
        [DataRow("evnt 1 -1 2500 2500")]
        [DataRow("evnt 1 0 2490 2500")]
        [DataRow("evnt 3 1 -1 -1")]
        [DataRow("qstlist")]
        [DataRow("qstlist 5.1526.1526.7.0.1.0.0.0.0.0.0.0.0.0.0")]
        [DataRow("script 1 1970")]
        [DataRow("script 2 10")]
        [DataRow("pski 1292 1293")]
        [DataRow("petski -2")]
        [DataRow("petski 790 -1 -1")]
        [DataRow("sr -10 16 150")]
        [DataRow("sr 0")]
        [DataRow("stash 0.-1685.1.1.0.0.0.0")]
        [DataRow("ivn 9  2.0.0.0")]
        [DataRow("ivn 10  0.5967.5.0")]
        [DataRow("ivn 1 5.-9276.1.0")]
        [DataRow("minfo 1 0 -1.0/0 -1.0/0 -1/0 -1.0/0 0 3 0")]
        [DataRow("minfo 2 0 -1.0/0 -1.0/0 -1/0 -1.0/0 0 3 0")]
        [DataRow("c_mode 1 6023964 1000446 0 0 0 100 7607")]
        [DataRow("in 1 Anonymous - 6023964 78 84 2 0 1 3 99 3 343.4953.4621.4471.227.8672.4150.4142.4669.4531.-1 100 100 0 -1 4 1 0 57 0 1000446 87 88 -1 - 27 0 0 0 0 99 0 0|0|0 0 0 100 72 9444")]
        [DataRow("bpt 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 6545 6545 -997 -997 -997 -997 -997 -997 -997 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265")]
        [DataRow("bpt 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 6544 6544 -997 -997 -997 -997 -997 -997 -997 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264 97264")]
        [DataRow("sayitemt 1 13793130 17 1 13763 Anonymous WTS|{%s} IconInfo 13763")]
        [DataRow("sayitemt 1 7603048 17 1 4240 Anonymous wts|{%s} e_info 7 4240 1 910 99 0 5991794 20 94 0 52 4 0 100 0 0 0 0 48 16 27 29 20 14 10 11")]
        [DataRow("sayitemt 1 8246435 16 3 9476 Anonymous IconInfo 9476")]
        [DataRow("sayitemt 1 7685516 16 2 4415 Anonymous e_info 7 4415 1 2709 1 0 15 0 0 4")]
        [DataRow("sayitemt 1 13807078 16 4 909 Anonymous slinfo 0 909 10 99 50 9 0 0 0 0 0 0 0 3 3 2 5 13 0 5991794 890.891.892.893.894.895.896.897.898.899 7319457 27 75 0 55 0 15 0 0 0 25 25 10 10 5 0 1 1 1 1 0 1 0 0 9212 0 0")]
        [DataRow("delay 5000 1 #guri^710^22^72^7282")]
        public void ACapturedLineReadsBackUnchanged(string line)
        {
            var packet = Deserializer.Deserialize(line);

            Assert.AreEqual(line, Serializer.Serialize(packet));
            Assert.IsTrue(((PacketBase)packet).IsValid, string.Join("; ", ((PacketBase)packet).ValidationResult.Select(result => result.ErrorMessage)));
        }

        [TestMethod]
        public void AQuicklistSlotStartsWithItsType()
        {
            var slot = (QSlotPacket)Deserializer.Deserialize("qslot 1 1.1.0 1.1.1 1.1.2 1.1.3 1.1.4 1.1.5 1.1.10 1.1.9 1.1.8 1.1.7 1.1.6 7.-1.-1 7.-1.-1 7.-1.-1 1.3.1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 0.1.5 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 7.-1.-1 0.1.-1");

            Assert.AreEqual((QSetType.Set, (short)3, (short)1, (short?)null),
                (slot.Data![14]!.Type, slot.Data[14]!.OriginQuickList, slot.Data[14]!.OriginQuickListSlot, slot.Data[14]!.Data));
            Assert.AreEqual(QSetType.Reset, slot.Data[11]!.Type);
        }

        [TestMethod]
        public void AFreezeTimerGuriCarriesNoEntity()
        {
            var guri = (GuriPacket)Deserializer.Deserialize("guri 8 8");

            Assert.AreEqual((GuriPacketType.FreezeTimer, 8u, (long?)null), (guri.Type, guri.Argument, guri.EntityId));
            Assert.AreEqual("guri 8 8", Serializer.Serialize(new GuriPacket { Type = GuriPacketType.FreezeTimer, Argument = 8, EntityId = null }));
        }

        [TestMethod]
        public void TheRoomMapNamesItsTimeSpace()
        {
            Assert.AreEqual((short)628, ((RsfmPacket)Deserializer.Deserialize("rsfm 628 2 0 0 0")).TimeSpaceId);
        }

        [TestMethod]
        public void OnlyAPlayerModeCarriesItsSizeAndSkin()
        {
            var monster = (CModePacket)Deserializer.Deserialize("c_mode 3 5118 462 0 0");
            var player = (CModePacket)Deserializer.Deserialize("c_mode 1 14293841 3711 0 0 0 100 0");

            Assert.AreEqual(((byte?)null, (byte?)null, (short?)null), (monster.MorphBonus, monster.Size, monster.MorphSkin));
            Assert.AreEqual(((short)3711, (byte?)100, (short?)0), (player.Morph, player.Size, player.MorphSkin));
        }

        [TestMethod]
        public void TheCharacterIconCanBeADignityIcon()
        {
            var info = (CInfoPacket)Deserializer.Deserialize("c_info Anonymous - -1 -1 - 9999999 0 1 0 9 3 -2 0 0 0 0 0 0 0 -1");

            Assert.AreEqual(ExtendedReputationType.Suspected, info.Icon);
        }

        [TestMethod]
        public void TheRewardChestLineStartsWithAnEmptyField()
        {
            var repay = (RepayPacket)Deserializer.Deserialize("repay  2028.0.5 -1.0.0 -1.0.0 -1.0.0 -1.0.0 -1.0.0");

            Assert.AreEqual(((short?)2028, (short)5), (repay.BonusRewards[0].ItemId, repay.BonusRewards[0].Amount));
            Assert.IsNull(repay.DrawnReward.ItemId);
        }

        [TestMethod]
        public void AnItemUseLeftWithoutParameterIsWrittenWithout()
        {
            Assert.AreEqual("delay 5000 7 #u_i^1^14882169^2^2^4", Serializer.Serialize(new DelayPacket
            {
                Delay = 5000,
                Type = DelayPacketType.ItemInUse,
                Packet = new ClientPackets.Inventory.UseItemPacket
                {
                    VisualType = VisualType.Player,
                    VisualId = 14882169,
                    Type = PocketType.Etc,
                    Slot = 2,
                    Mode = 4,
                },
            }));
        }

        [TestMethod]
        public void TheLanguagesAreFollowedByOneMoreField()
        {
            // The first field is 11 or 15 in these lines, which VisualType does not define.
            const string line = "twk 11 14882169 Account Anonymous shtmxpdlfeoqkr en en 0";

            Assert.AreEqual(line, Serializer.Serialize(Deserializer.Deserialize(line)));
        }

        [TestMethod]
        public void TheMapScoreIsANumber()
        {
            Assert.AreEqual(628, ((RnscPacket)Deserializer.Deserialize("rnsc 628")).Score);
        }

        [TestMethod]
        public void TheSpecialistModeNamesTheSpecialistMorph()
        {
            var mode = (SModePacket)Deserializer.Deserialize("s_mode 1 14293841 13 0");

            Assert.AreEqual((VisualType.Player, 14293841L, (short)13), (mode.VisualType, mode.VisualId, mode.SpecialistMorph));
        }

        [TestMethod]
        public void TheServerClockStartsWithAnEmptyField()
        {
            var now = (NowTimePacket)Deserializer.Deserialize("nowtime  13 40 30");

            Assert.AreEqual(((byte)13, (byte)40, (byte)30), (now.Hour, now.Minute, now.Second));
            Assert.AreEqual("nowtime  13 40 30", Serializer.Serialize(new NowTimePacket { Hour = 13, Minute = 40, Second = 30 }));
        }

        [TestMethod]
        public void TheQuestNpcLineHoldsTenGroups()
        {
            var qnpc = (QnpcPacket)Deserializer.Deserialize("qnpc 331|1|19 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1 -1|-1|-1");

            Assert.AreEqual(10, qnpc.SubPackets.Count);
            Assert.AreEqual(((short)331, (short)1, (short)19), (qnpc.SubPackets[0].Unknown0, qnpc.SubPackets[0].Unknown1, qnpc.SubPackets[0].Unknown2));
        }

        [TestMethod]
        public void ADanceGuriNamesItsEntity()
        {
            var dance = (GuriDancePacket)Deserializer.Deserialize("guri 2 1 14882169 0");

            Assert.AreEqual((VisualType.Player, 14882169L), (dance.VisualType, dance.VisualId));
            Assert.AreEqual("guri 2 2 1659263 0", Serializer.Serialize(new GuriDancePacket { VisualType = VisualType.Npc, VisualId = 1659263 }));
        }

        [TestMethod]
        public void AMatePickUpRefusedGuriNamesThePet()
        {
            var guri = (GuriPacket)Deserializer.Deserialize("guri 16 2 5922210");

            Assert.AreEqual((GuriPacketType.MatePickUpRefused, 2u, (uint?)5922210), (guri.Type, guri.Argument, guri.SecondArgument));
        }

        [TestMethod]
        public void TheRaidAnnouncementsHaveTheirOwnMessageTypes()
        {
            Assert.AreEqual(MessageType.EventCountdown, ((MsgiPacket)Deserializer.Deserialize("msgi 6 2298 10 361 5 0 0")).Type);
            Assert.AreEqual(MessageType.EventRegistration, ((MsgiPacket)Deserializer.Deserialize("msgi 9 2302 0 0 0 0 0")).Type);
        }

        [TestMethod]
        [DataRow("bsinfo 2 1 0 0", BscPacketType.SheepFarm)]
        [DataRow("bsinfo 2 4 0 0", BscPacketType.DodgeMeteor)]
        [DataRow("bsinfo 2 99 0 0", BscPacketType.BushiKingDefence)]
        public void ARaidSearchWindowClosesWithItsRaid(string line, BscPacketType raid)
        {
            Assert.AreEqual(raid, ((BSInfoPacket)Deserializer.Deserialize(line)).Title);
        }

        [TestMethod]
        public void AWaxedHairstyleIsReadByName()
        {
            var eq = (EqPacket)Deserializer.Deserialize("eq 14639620 0 1 11 15 2 8795.8645.4620.4628.4610.8674.8884.8886.8869.8888.8880 97 87 100");

            Assert.AreEqual(HairStyleType.ChoppyBangs, eq.HairStyle);
        }

        [TestMethod]
        public void ATimeSpaceReachedButNotDoneIsItsOwnPortalType()
        {
            Assert.AreEqual(WpPortalType.NormalTsReachable, ((WpPacket)Deserializer.Deserialize("wp 45 173 6 1 15 99")).PortalType);
        }

        [TestMethod]
        public void TheRoomMapIsSentAgainWhenTheRunIsClearedAndWhenARoomMissionStarts()
        {
            Assert.AreEqual(RsfmPacketType.Cleared, ((RsfmPacket)Deserializer.Deserialize("rsfm 4 1 6 12 0")).Type);
            Assert.AreEqual(RsfmPacketType.RoomMissionStarted, ((RsfmPacket)Deserializer.Deserialize("rsfm 33 2 0 0 0")).Type);
        }

        [TestMethod]
        [DataRow("evnt 1 -1 2500 2500", EventTimerState.Waiting)]
        [DataRow("evnt 1 0 2490 2500", EventTimerState.Running)]
        [DataRow("evnt 3 1 -1 -1", EventTimerState.Stopped)]
        public void ATimerIsWaitingRunningOrStopped(string line, EventTimerState state)
        {
            Assert.AreEqual(state, ((EventPacket)Deserializer.Deserialize(line)).State);
        }

        [TestMethod]
        public void TheKillAllObjectiveIsCompletedOnceTheMonstersAreDead()
        {
            Assert.AreEqual(MinfoObjectiveState.Completed,
                ((MinfoPacket)Deserializer.Deserialize("minfo 2 0 -1.0/0 -1.0/0 -1/0 -1.0/0 0 3 0")).KillAllMonsters);
        }

        [TestMethod]
        public void AScriptLineNamesTheScriptAndItsStep()
        {
            var script = (ScriptPacket)Deserializer.Deserialize("script 1 1970");

            Assert.AreEqual((1, 1970), (script.ScriptId, script.ScriptStepId));
        }

        [TestMethod]
        public void AnEmptyQuestListIsTheHeaderAlone()
        {
            var list = (QstlistPacket)Deserializer.Deserialize("qstlist");

            Assert.AreEqual(0, list.QuestSubPackets.Count);
            Assert.AreEqual("qstlist", Serializer.Serialize(new QstlistPacket()));
        }

        [TestMethod]
        public void AMountPocketLineHasAnEmptyFieldBeforeItsItem()
        {
            var ivn = (IvnPacket)Deserializer.Deserialize("ivn 9  2.0.0.0");

            Assert.AreEqual((short)2, ivn.IvnSubPackets![0].Slot);
            Assert.AreEqual("ivn 1 5.-9276.1.0", Serializer.Serialize(new IvnPacket
            {
                Type = PocketType.Main,
                IvnSubPackets = [new IvnSubPacket { Slot = 5, VNum = 9276, IsLimited = true, RareAmount = 1, UpgradeDesign = 0, SecondUpgrade = null, Unknown5 = null, Unknown6 = null }],
            }));
        }

        [TestMethod]
        public void AStashedItemCarriesTwoMoreFields()
        {
            var item = ((StashClientPacket)Deserializer.Deserialize("stash 0.-1685.1.1.0.0.0.0")).Items![0];

            Assert.AreEqual(((short)1685, true, (short)1, (short?)0, (short?)0), (item.VNum, item.IsLimited, item.Amount, item.Unknown6, item.Unknown7));
        }

        [TestMethod]
        public void AMorphCanExceedAShort()
        {
            Assert.AreEqual(1000446, ((CModePacket)Deserializer.Deserialize("c_mode 1 6023964 1000446 0 0 0 100 7607")).Morph);
        }

        [TestMethod]
        public void ASkillLessSuEndsBeforeTheTargetHp()
        {
            var su = (SuPacket)Deserializer.Deserialize("su 1 14608437 3 3040 -1 0 15 -1 -1 -1 1 1 0 -1 0");

            Assert.AreEqual(((int?)null, (int?)null), (su.TargetCurrentHp, su.TargetMaxHp));
        }

        [TestMethod]
        public void ThePetSkillBarCanBeASingleSentinel()
        {
            var petski = (PetskiPacket)Deserializer.Deserialize("petski -2");

            Assert.AreEqual(((short)-2, (short?)null, (short?)null), (petski.FirstSkillVNum, petski.SecondSkillVNum, petski.ThirdSkillVNum));
        }

        [TestMethod]
        public void TheBattlePassTimersAreAList()
        {
            var bpt = (ServerPackets.Player.BptPacket)Deserializer.Deserialize("bpt 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 6545 6545 -997 -997 -997 -997 -997 -997 -997 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265 97265");

            Assert.AreEqual(48, bpt.MinutesRemaining.Count);
            Assert.AreEqual((97265L, 6545L, -997L), (bpt.MinutesRemaining[0], bpt.MinutesRemaining[22], bpt.MinutesRemaining[24]));
        }

        [TestMethod]
        public void TheTimeSpaceCardStateFieldsAreNumbers()
        {
            var rbr = (RbrPacket)Deserializer.Deserialize("rbr 3.0.0 4 15 10.99 1 205.1 207.1 208.1 209.1 210.1 203.1 -1.0 10.1 -1.0 -1.0 1120.Anonymous 0 0 A Difficult Decision\rYour skills will be seriously put to the test in this Time-Space.");

            Assert.AreEqual(((byte)4, (byte)15), (rbr.Unknown, rbr.Unknown2));
        }

        // Questions carry the packet the client sends back, so the client's own classes read them.
        private static readonly Deserializer QuestionDeserializer = new(new[]
        {
            typeof(QnaiPacket), typeof(QnamliPacket), typeof(ClientPackets.UI.GuriPacket), typeof(ISortPacket), typeof(NrunPacket),
        });

        [TestMethod]
        [DataRow("qnamli 1 #guri^506 379 0 0 0")]
        [DataRow("qnamli 4 #guri^514 2301 0 0 0")]
        [DataRow("qnai #isort^0^1 2585 0 0 0")]
        [DataRow("qnai #n_run^3001^2^2^3096^1 999 0 0 0")]
        public void AQuestionCarriesTheClientPacketUnchanged(string line)
        {
            Assert.AreEqual(line, Serializer.Serialize(QuestionDeserializer.Deserialize(line)));
        }

        [TestMethod]
        public void AnItemMovesBetweenPockets()
        {
            var move = (Mve2Packet)new Deserializer(new[] { typeof(Mve2Packet) }).Deserialize("mve2 9 2 1 5");

            Assert.AreEqual((PocketType.Mount, (short)2, PocketType.Main, (short)5),
                (move.InventoryType, move.Slot, move.DestinationInventoryType, move.DestinationSlot));
            Assert.AreEqual("mve2 9 2 1 5", Serializer.Serialize(move));
        }

        [TestMethod]
        public void ATeleportStoneAsksForTheCellAndTheStone()
        {
            var delay = (DelayPacket)Deserializer.Deserialize("delay 5000 1 #guri^710^22^72^7282");
            var answer = (GuriMapTeleporterPacket)delay.Packet!;

            Assert.AreEqual(((short)22, (short)72, 7282L), (answer.DestinationX, answer.DestinationY, answer.NpcId));
        }

        [TestMethod]
        public void TheTimeSpaceEntryIsAnsweredWithOrWithoutItsType()
        {
            var deserializer = new Deserializer(new[] { typeof(ClientPackets.Instance.RStartPacket) });

            Assert.AreEqual((RStartPacketType?)RStartPacketType.TimeSpaceInstanceEntry, ((ClientPackets.Instance.RStartPacket)deserializer.Deserialize("#rstart^1")).Type);
            Assert.IsNull(((ClientPackets.Instance.RStartPacket)deserializer.Deserialize("rstart")).Type);
            Assert.AreEqual("rstart", Serializer.Serialize(new ClientPackets.Instance.RStartPacket()));
        }
    }
}
