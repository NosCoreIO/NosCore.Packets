//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Packets.ServerPackets.Mates;
using NosCore.Packets.ServerPackets.Visibility;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.Tests
{
    [PacketHeader("tstsep", Scope.InGame)]
    public class SeparatorProbePacket : PacketBase
    {
        [PacketIndex(0)] public int Before { get; set; }
        [PacketIndex(1)] public string? Middle { get; set; }
        [PacketIndex(2)] public int After { get; set; }
        [PacketIndex(3)] public string? Last { get; set; }
    }

    [PacketHeader("tstdot", Scope.InGame)]
    public class DottedProbePacket : PacketBase
    {
        [PacketIndex(0)] public int Before { get; set; }
        [PacketIndex(1, SpecialSeparator = ".")] public string? Dotted { get; set; }
        [PacketIndex(2)] public int After { get; set; }
    }

    // A value that contains the field separator used to split its own field in two and shift
    // every field after it. The escaping existed but was aimed at SpecialSeparator, which an
    // ordinary property never declares.
    [TestClass]
    public class StringFieldSeparatorTests
    {
        private static readonly ISerializer Serializer =
            new Serializer(new[]
            {
                typeof(SeparatorProbePacket), typeof(DottedProbePacket),
                typeof(ScpPacket), typeof(ScnPacket), typeof(InPacket)
            });

        [TestMethod]
        public void ASpaceInAMiddleFieldIsEscaped()
        {
            Assert.AreEqual("tstsep 1 Joyeux^Mouton 2 -",
                Serializer.Serialize(new SeparatorProbePacket { Before = 1, Middle = "Joyeux Mouton", After = 2 }));
        }

        [TestMethod]
        public void TheLastFieldKeepsItsSpaces()
        {
            // Nothing follows it, so nothing can shift - and chat lines rely on this.
            Assert.AreEqual("tstsep 1 - 2 hello there",
                Serializer.Serialize(new SeparatorProbePacket { Before = 1, After = 2, Last = "hello there" }));
        }

        [TestMethod]
        public void AFieldWithItsOwnSeparatorEscapesThatSeparatorAndNotTheSpace()
        {
            Assert.AreEqual("tstdot 1.a^b 2",
                Serializer.Serialize(new DottedProbePacket { Before = 1, Dotted = "a.b", After = 2 }));
        }

        [TestMethod]
        public void ASpacedNameNoLongerSplitsTheMatePacket()
        {
            var wire = Serializer.Serialize(new ScpPacket
            {
                PetId = 1, NpcMonsterVNum = 333, Level = 15, Name = "Joyeux Mouton", IsSummonable = true
            });

            StringAssert.Contains(wire, "Joyeux^Mouton");
            Assert.IsFalse(wire.Contains("Joyeux Mouton"));
        }

        [TestMethod]
        public void TheSameHoldsForTheOtherPacketsThatCarryAName()
        {
            // ScnPacket.Name is index 36 of more, InPacket.Name is index 1 of many - neither is
            // last, so both are escaped now. ScnPacket has said "Spaces should be replaced by ^"
            // in a doc comment the whole time without anything enforcing it.
            var scn = Serializer.Serialize(new ScnPacket
            {
                PetId = 1, NpcMonsterVNum = 333, Level = 15, Name = "Joyeux Mouton"
            });
            StringAssert.Contains(scn, "Joyeux^Mouton");
            Assert.IsFalse(scn.Contains("Joyeux Mouton"));

            var inp = Serializer.Serialize(new InPacket
            {
                VisualType = VisualType.Npc, Name = "Joyeux Mouton", VNum = "333", VisualId = 1
            });
            StringAssert.Contains(inp, "Joyeux^Mouton");
            Assert.IsFalse(inp.Contains("Joyeux Mouton"));
        }
    }
}
