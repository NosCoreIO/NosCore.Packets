//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Entities;
using NosCore.Packets.ServerPackets.UI;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    // Lines taken from a packet trace of the live game.
    [TestClass]
    public class GuriForcedMovePacketTests
    {
        private static readonly Serializer Serializer = new(new[] { typeof(GuriForcedMovePacket), typeof(GuriPacket) });

        // The forced move is known first, so the other guri lines cannot reach the general packet by order alone.
        private static readonly Deserializer Deserializer = new(new[] { typeof(GuriForcedMovePacket), typeof(GuriPacket) });

        [TestMethod]
        public void ACasterThrownBackSlidesToItsCell()
        {
            Assert.AreEqual("guri 3 1 9836127 13 169 3 2 2 -1 1", Serializer.Serialize(new GuriForcedMovePacket
            {
                VisualType = VisualType.Player,
                VisualId = 9836127,
                X = 13,
                Y = 169,
                Unknown9 = 1,
            }));
        }

        [TestMethod]
        public void AChargingMonsterSlidesToItsTarget()
        {
            Assert.AreEqual("guri 3 3 5935402 9 13 3 2 2 11 0", Serializer.Serialize(new GuriForcedMovePacket
            {
                VisualType = VisualType.Monster,
                VisualId = 5935402,
                X = 9,
                Y = 13,
                Unknown8 = 11,
            }));
        }

        [TestMethod]
        [DataRow("guri 3 1 9836127 13 169 3 2 2 -1 1")]
        [DataRow("guri 3 3 5935402 9 13 3 2 2 11 0")]
        [DataRow("guri 3 3 5935135 21 14 3 2 2 11 0")]
        [DataRow("guri 3 3 2910 52 160 3 8 2 -1 0")]
        public void AForcedMoveReadsBackAsWritten(string line)
        {
            var packet = Deserializer.Deserialize(line);

            Assert.IsInstanceOfType(packet, typeof(GuriForcedMovePacket));
            Assert.AreEqual(line, Serializer.Serialize(packet));
        }

        [TestMethod]
        public void AForcedMoveReadsItsEntityAndCell()
        {
            var packet = (GuriForcedMovePacket)Deserializer.Deserialize("guri 3 3 2910 52 160 3 8 2 -1 0");

            Assert.AreEqual((GuriPacketType.ForcedMove, VisualType.Monster, 2910L, (short)52, (short)160, (byte)8),
                (packet.Type, packet.VisualType, packet.VisualId, packet.X, packet.Y, packet.Unknown6));
        }

        [TestMethod]
        [DataRow("guri 6 2 7560447 10 0")]
        [DataRow("guri 0 1 14882921 2 60")]
        [DataRow("guri 31 1 14293841 23 15")]
        [DataRow("guri 16 2 5922210")]
        [DataRow("guri 4 32 0")]
        [DataRow("guri 8 8")]
        [DataRow("guri 2 1 14293841 0")]
        public void TheOtherGuriLinesStayGeneral(string line)
        {
            Assert.IsInstanceOfType(Deserializer.Deserialize(line), typeof(GuriPacket));
        }
    }
}
