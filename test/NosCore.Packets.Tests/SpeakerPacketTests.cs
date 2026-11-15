//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Chats;
using NosCore.Packets.ServerPackets.Inventory;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class SpeakerPacketTests
    {
        private static readonly Serializer Serializer =
            new(new[] { typeof(SaytPacket), typeof(SayItemtPacket), typeof(IconInfoPacket), typeof(EInfoCostumePacket) });

        private static readonly Deserializer Deserializer =
            new(new[] { typeof(SaytPacket), typeof(SayItemtPacket), typeof(IconInfoPacket) });

        [TestMethod]
        public void TheSpeakerLineCarriesTheNameBeforeTheMessage()
        {
            Assert.AreEqual("sayt 1 14882866 13 KaiserinEU WTS RANGER +15p100",
                Serializer.Serialize(new SaytPacket
                {
                    VisualType = VisualType.Player,
                    VisualId = 14882866,
                    Type = SayColorType.LightPurple,
                    VisualName = "KaiserinEU",
                    Message = "WTS RANGER +15p100",
                }));
        }

        [TestMethod]
        public void TheLinkedItemMessageWritesItsSpacesAsBarsAndTheIconInline()
        {
            Assert.AreEqual("sayitemt 1 7683814 17 1 1219 Elenzius {%s}1.3kk|basar|next|1,7kk IconInfo 1219",
                Serializer.Serialize(new SayItemtPacket
                {
                    VisualType = VisualType.Player,
                    VisualId = 7683814,
                    OratorSlot = 17,
                    Type = 1,
                    ItemVNum = 1219,
                    VisualName = "Elenzius",
                    Message = "{%s}1.3kk basar next 1,7kk",
                    ItemInfo = new IconInfoPacket { IconId = 1219 },
                }));
        }

        [TestMethod]
        public void TheLinkedEquipmentInfoIsWrittenAsItsOwnLine()
        {
            var info = new EInfoCostumePacket { ItemVNum = 4240, LevelMinimum = 1 };

            var line = Serializer.Serialize(new SayItemtPacket
            {
                VisualType = VisualType.Player,
                VisualId = 8199079,
                OratorSlot = 17,
                Type = 1,
                ItemVNum = 4240,
                VisualName = "Seller",
                Message = "WTS{%s}",
                ItemInfo = info,
            });

            Assert.AreEqual($"sayitemt 1 8199079 17 1 4240 Seller WTS{{%s}} {Serializer.Serialize(info)}", line);
        }

        [TestMethod]
        public void AMessageThatLooksLikeAPlaceholderIsWrittenAsTyped()
        {
            Assert.AreEqual("sayitemt 1 7 17 1 1219 Seller IPacketToInject IconInfo 1219",
                Serializer.Serialize(new SayItemtPacket
                {
                    VisualType = VisualType.Player,
                    VisualId = 7,
                    OratorSlot = 17,
                    Type = 1,
                    ItemVNum = 1219,
                    VisualName = "Seller",
                    Message = "IPacketToInject",
                    ItemInfo = new IconInfoPacket { IconId = 1219 },
                }));
        }

        [TestMethod]
        public void AMissingItemInfoIsWrittenAsAbsent()
        {
            Assert.AreEqual("sayitemt 1 7 17 1 1219 Seller WTS -1",
                Serializer.Serialize(new SayItemtPacket
                {
                    VisualType = VisualType.Player,
                    VisualId = 7,
                    OratorSlot = 17,
                    Type = 1,
                    ItemVNum = 1219,
                    VisualName = "Seller",
                    Message = "WTS",
                }));
        }

        [TestMethod]
        public void TheLinkedItemMessageReadsBack()
        {
            var packet = (SayItemtPacket)Deserializer.Deserialize(
                "sayitemt 1 7683814 17 1 1219 Elenzius {%s}1.3kk|basar|next|1,7kk IconInfo 1219");

            Assert.AreEqual((short)1219, packet.ItemVNum);
            Assert.AreEqual("Elenzius", packet.VisualName);
            Assert.AreEqual("{%s}1.3kk basar next 1,7kk", packet.Message);
            Assert.AreEqual((short)1219, ((IconInfoPacket)packet.ItemInfo!).IconId);
        }
    }
}
