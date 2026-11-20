//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Tests.ProbeServerPackets;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class SharedHeaderFirstFieldTests
    {
        [TestMethod]
        public void AFirstFieldThatCouldNotBeReadIsReadAgainOnTheNextLine()
        {
            var deserializer = new Deserializer(new[] { typeof(FirstShapePacket), typeof(SecondShapePacket) });

            Assert.ThrowsExactly<ArgumentException>(() => deserializer.Deserialize("shape_probe 2 5"));
            Assert.AreEqual(5, ((SecondShapePacket)deserializer.Deserialize("shape_probe 2 5")).Value);
        }
    }
}

// The deserializer only tells shapes of a header apart in a namespace naming ServerPackets.
namespace NosCore.Packets.Tests.ProbeServerPackets
{
    [PacketHeader("shape_probe", Scope.InGame, AllowDuplicateHeader = true)]
    public class FirstShapePacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Kind { get; set; } = 1;

        [PacketIndex(1)]
        public int Value { get; set; }
    }

    [PacketHeader("shape_probe", Scope.InGame, AllowDuplicateHeader = true)]
    public class SecondShapePacket : PacketBase
    {
        // The first read of this shape's kind fails, as a getter that is not ready yet would.
        private static int _reads;
        private byte _kind = 2;

        [PacketIndex(0)]
        public byte Kind
        {
            get => Interlocked.Increment(ref _reads) == 1 ? throw new InvalidOperationException() : _kind;
            set => _kind = value;
        }

        [PacketIndex(1)]
        public int Value { get; set; }
    }
}
