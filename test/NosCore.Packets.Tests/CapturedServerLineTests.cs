//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Event;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Packets.ServerPackets.Player;
using NosCore.Packets.ServerPackets.Quicklist;
using NosCore.Packets.ServerPackets.TimeSpaces;
using NosCore.Packets.ServerPackets.UI;
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
        public void ACapturedLineReadsBackUnchanged(string line)
        {
            Assert.AreEqual(line, Serializer.Serialize(Deserializer.Deserialize(line)));
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
    }
}
