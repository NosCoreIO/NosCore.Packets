//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.ClientPackets.Mates;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Mates;
using NosCore.Packets.ServerPackets.Visibility;
using NosCore.Shared.Enumerations;
using System.Linq;

namespace NosCore.Packets.Tests
{
    // The expected lines were recorded from the official server in October 2026, for a character with four pets and
    // two partners. Server packets are built and compared with what that server wrote; ptctl, which the client
    // sends, is read.
    [TestClass]
    public class OfficialMatePacketTests
    {
        private static readonly IDeserializer Deserializer = new Deserializer(PacketCorpus.SerializableTypes.ToList());
        private static readonly ISerializer Serializer = new Serializer(PacketCorpus.SerializableTypes.ToList());

        [TestMethod]
        public void APetIsListedAsTheOfficialServerListsIt()
        {
            var packet = new ScpPacket
            {
                PetId = 2, NpcMonsterVNum = 2682, TransportId = 1135622, Level = 48, Loyalty = 397, Experience = 86580,
                DamageMinimum = 356, DamageMaximum = 480, Concentrate = 271, CriticalChance = 6, CriticalRate = 80,
                CloseDefence = 185, DefenceDodge = 274, DistanceDefence = 158, DistanceDefenceDodge = 274, MagicDefence = 135,
                Element = 4, FireResistance = 60, WaterResistance = 50, LightResistance = 40, DarkResistance = 70,
                Hp = 10638, MaxHp = 10638, Mp = 708, MaxMp = 708, XpLoad = 476535, Name = "@", Unknow3 = 3, Unknow8 = 1
            };

            Assert.AreEqual(
                "sc_p 2 2682 1135622 48 397 86580 0 0 356 480 271 6 80 0 185 274 158 274 135 4 60 50 40 70 10638 10638 708 708 0 476535 0 @ 0 0 3 0 0 0 0 1",
                Serializer.Serialize(packet));
        }

        [TestMethod]
        public void APartnerIsListedAsTheOfficialServerListsIt()
        {
            var packet = new ScnPacket
            {
                PetId = 0, NpcMonsterVNum = 317, TransportId = 1135623, Level = 28, Loyalty = 1000, Experience = 13458,
                Unknown3 = 1, MinimumAttack = 69, MaximumAttack = 69, Precision = 138, Defence = 29, DefenceDodge = 69,
                DistanceDefence = 34, DistanceDodge = 69, DodgeRate = 26, Hp = 1902, HpMax = 2165, Mp = 877, MpMax = 877,
                LevelXp = 190440, Name = "@", MorphId = -1, Unknown5 = 1
            };

            Assert.AreEqual(
                "sc_n 0 317 1135623 28 1000 13458 -1 -1 -1 -1 0 0 1 0 69 69 138 0 0 0 29 69 34 69 26 0 0 0 0 0 1902 2165 877 877 0 190440 @ -1 0 -1 -1 -1 -1 0 1",
                Serializer.Serialize(packet));
        }

        [TestMethod]
        public void AMateSpawnsAsOnTheOfficialServer()
        {
            var packet = new InPacket
            {
                VisualType = VisualType.Npc, VNum = "830", VisualId = 1135624, PositionX = 14, PositionY = 11, Direction = 2,
                InNonPlayerSubPacket = new InNonPlayerSubPacket
                {
                    InAliveSubPacket = new InAliveSubPacket { Hp = 100, Mp = 100 },
                    GroupEffect = 3, Owner = 12988838, SpawnEffect = SpawnEffectType.NoEffect, Name = "@", Unknow1 = 2,
                    Unknow7 = 2
                }
            };

            Assert.AreEqual(
                "in 2 830 1135624 14 11 2 100 100 0 0 3 12988838 1 0 -1 @ 2 -1 0 0 0 0 0 0 0 0 0 0 0 2 0",
                Serializer.Serialize(packet));
        }

        [TestMethod]
        public void AMonsterSpawnsAsOnTheOfficialServer()
        {
            var packet = new InPacket
            {
                VisualType = VisualType.Monster, VNum = "24", VisualId = 2887, PositionX = 27, PositionY = 145, Direction = 2,
                InNonPlayerSubPacket = new InNonPlayerSubPacket
                {
                    InAliveSubPacket = new InAliveSubPacket { Hp = 100, Mp = 100 }
                }
            };

            Assert.AreEqual(
                "in 3 24 2887 27 145 2 100 100 0 0 0 -1 0 0 -1 - 0 -1 0 0 0 0 0 0 0 0 0 0 0 0 0",
                Serializer.Serialize(packet));
        }

        [TestMethod]
        public void TheFollowReportListsEachMateThenOneSpeed()
        {
            var packet = (PtctlPacket)Deserializer.Deserialize("ptctl 1 2 1135623 50 132 1135626 49 133 1135623 9");

            Assert.AreEqual(2, packet.Amount);
            Assert.AreEqual((1135623L, (short)50, (short)132),
                (packet.Mates![0]!.VisualId, packet.Mates[0]!.PositionX, packet.Mates[0]!.PositionY));
            Assert.AreEqual((1135626L, (short)49, (short)133),
                (packet.Mates[1]!.VisualId, packet.Mates[1]!.PositionX, packet.Mates[1]!.PositionY));
            Assert.AreEqual(1135623, packet.VisualId);
            Assert.AreEqual(9, packet.Speed);
        }

        [TestMethod]
        [DataRow("ptctl 1 1 1135626 50 149 1135626 7")]
        [DataRow("ptctl 1 2 1135623 50 132 1135626 49 133 1135623 9")]
        public void AFollowReportWritesBackUnchanged(string line)
        {
            Assert.AreEqual(line, Serializer.Serialize(Deserializer.Deserialize(line)));
        }
    }
}
