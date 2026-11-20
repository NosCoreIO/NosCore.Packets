//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Player;

namespace NosCore.Packets.Tests
{
    [TestClass]
    public class LineReadingTests
    {
        // Traced: every skill a character knows, four fields a skill.
        private const string StpLine = "stp 0 1 1 -1 1 1 1 -1 2 1 1 -1 4 1 1 -1 5 1 1 -1 7 1 1 -1 8 1 1 -1 9 1 1 -1 10 1 1 -1 11 1 1 -1 12 1 1 -1 13 1 1 -1 14 1 1 -1 15 1 1 -1 16 1 1 -1 17 1 1 -1 73 1 1 -1 74 1 1 -1 75 1 1 -1 76 1 1 -1 77 1 1 -1 78 1 1 -1 79 1 1 -1 80 1 1 -1 82 1 1 -1 83 1 1 -1 84 1 1 -1 85 1 1 -1 86 1 1 -1 87 1 1 -1 88 1 1 -1 89 1 1 -1 96 1 1 -1 97 1 1 -1 98 1 1 -1 99 1 1 -1 100 1 1 -1 101 1 1 -1 102 1 1 -1 103 1 1 -1 104 1 1 -1 200 1 1 -1 201 1 1 -1 202 1 1 -1 203 1 1 -1 204 1 1 -1 205 1 1 -1 206 1 1 -1 207 1 1 -1 333 1 1 -1 176 2 2 -1 177 2 2 -1 179 2 2 -1 181 2 2 -1 290 2 2 -1 377 2 2 -1 398 2 2 -1 448 2 2 -1 478 2 2 -1 479 2 2 -1 480 2 2 -1 535 2 2 -1 544 2 2 -1 545 2 2 -1 555 2 2 -1 24 3 3 -1 581 2 2 -1 614 2 2 -1 615 2 2 -1 616 2 2 -1 630 2 2 -1 631 2 2 -1 632 2 2 -1 633 2 2 -1 634 2 2 -1 638 2 2 -1 639 2 2 -1 640 2 2 -1 641 2 2 -1 642 2 2 -1 643 2 2 -1 644 2 2 -1 663 2 2 -1 664 2 2 -1 667 2 2 -1 668 2 2 -1 669 2 2 -1 677 2 2 -1 678 2 2 -1 692 2 2 -1 728 2 2 -1 747 2 2 -1 752 2 2 -1 754 2 2 -1 762 2 2 -1 769 2 2 -1 794 2 2 -1 801 2 2 -1 813 2 2 -1 814 2 2 -1 815 2 2 -1 816 2 2 -1 821 2 2 -1 823 2 2 -1 824 2 2 -1 825 2 2 -1 830 2 2 -1 838 2 2 -1 841 2 2 -1 842 2 2 -1 843 2 2 -1 844 2 2 -1 1001 2 2 -1 1010 2 2 -1 1035 2 2 -1 1384 2 2 -1 1469 2 2 -1 1474 2 2 -1 1477 2 2 -1 1505 2 2 -1 1506 2 2 -1 1507 2 2 -1 1508 2 2 -1 1509 2 2 -1 2106 2 2 -1 2118 2 2 -1 2713 2 2 -1 3107 2 2 -1 3125 2 2 -1 3148 2 2 -1 3203 2 2 -1 37 3 3 -1 57 3 3 -1 136 3 3 -1 536 3 3 -1 537 3 3 -1 567 3 3 -1 608 3 3 -1 670 3 3 -1 671 3 3 -1 672 3 3 -1 673 3 3 -1 682 3 3 -1 687 3 3 -1 719 3 3 -1 755 2 2 -1 778 3 3 -1 779 3 3 -1";
        private const string Stp2Line = "stp2 784 3 3 -1 802 3 3 -1 826 3 3 -1 827 3 3 -1 829 3 3 -1 836 3 3 -1 846 3 3 -1 997 3 3 -1 1446 3 3 -1 1486 3 3 -1 2107 3 3 -1 2119 3 3 -1 2121 3 3 -1 2681 3 3 -1 2682 3 3 -1 2683 3 3 -1 2684 3 3 -1 2685 3 3 -1 2696 3 3 -1 2697 3 3 -1 2701 3 3 -1 2704 3 3 -1 2708 3 3 -1 2710 3 3 -1 2714 3 3 -1 2721 3 3 -1 3128 3 3 -1 709 4 4 -1 720 4 4 -1 803 4 4 -1 807 4 4 -1 808 4 4 -1 828 4 4 -1 840 4 4 -1 1456 4 4 -1 1470 4 4 -1 2105 4 4 -1 2120 4 4 -1 2709 4 4 -1 2715 4 4 -1 3149 4 4 -1 3150 4 4 -1 3284 4 4 -1 683 5 5 -1 714 5 5 -1 806 5 5 -1 1488 5 5 -1 2731 5 5 -1 2122 2 2 -1 31 3 3 -1 55 3 3 -1 64 3 3 -1 81 3 3 -1 2123 3 3 -1 2124 4 4 -1 156 2 2 -1 1109 2 2 -1 157 2 2 -1 158 2 2 -1 159 2 2 -1 1538 4 4 -1 1539 4 4 -1 1547 3 3 -1 1548 5 5 -1 1549 4 4 -1 1550 3 3 -1 1551 4 4 -1 1562 5 5 -1 2735 3 3 -1 2736 3 3 -1 2737 3 3 -1 2738 4 4 -1 2739 4 4 -1 2740 4 4 -1 2745 3 3 -1 2741 3 3 -1 2742 4 4 -1 2743 3 3 -1 2744 3 3 -1 2746 4 4 -1 2747 4 4 -1 2748 3 3 -1 2749 3 3 -1 2750 3 3 -1 2751 3 3 -1 2752 4 4 -1 2753 5 5 -1 2754 5 5 -1 2755 5 5 -1 2762 5 5 -1 1583 4 4 -1 1584 2 2 -1 1600 5 5 -1 1601 4 4 -1 1602 4 4 -1 1603 4 4 -1 1623 4 4 -1 1621 4 4 -1 1622 4 4 -1 1624 4 4 -1 1641 2 2 -1 1693 5 5 -1";

        private static readonly Serializer Serializer = new(new[]
        {
            typeof(StpPacket), typeof(Stp2Packet), typeof(StatPacket), typeof(JoinedListProbePacket),
        });

        private static readonly Deserializer Deserializer = new(new[]
        {
            typeof(StpPacket), typeof(Stp2Packet), typeof(StpSubPacket), typeof(StatPacket), typeof(JoinedListProbePacket),
            typeof(JoinedListProbeSubPacket),
        });

        [TestMethod]
        public void AListOfMoreThanAHundredAndTwentySevenItemsReadsWhole()
        {
            var stp = (StpPacket)Deserializer.Deserialize(StpLine);

            Assert.AreEqual(148, stp.SubPackets!.Count);
            Assert.AreEqual((779, (byte)3, (byte)3, (short)-1),
                (stp.SubPackets[147]!.SkillId, stp.SubPackets[147]!.Rank1, stp.SubPackets[147]!.Rank2, stp.SubPackets[147]!.Unknown));
            Assert.AreEqual(StpLine, Serializer.Serialize(stp));
        }

        [TestMethod]
        public void ASubPacketEndingWithMinusOneIsNotReadAsAnAbsentOne()
        {
            var stp2 = (Stp2Packet)Deserializer.Deserialize(Stp2Line);

            Assert.AreEqual(102, stp2.SubPackets!.Count);
            Assert.AreEqual(827, stp2.SubPackets[3]!.SkillId);
            Assert.AreEqual(Stp2Line, Serializer.Serialize(stp2));
        }

        [TestMethod]
        public void SubPacketsJoinedByTheirListSeparatorAreReadOnePerPart()
        {
            var line = Serializer.Serialize(new JoinedListProbePacket
            {
                Items = new List<JoinedListProbeSubPacket?>
                {
                    new() { Id = 1, Amount = 2 },
                    new() { Id = 3, Amount = 4 },
                },
            });
            var read = (JoinedListProbePacket)Deserializer.Deserialize(line);

            Assert.AreEqual("joined_list_probe 1.2|3.4", line);
            Assert.AreEqual(((short)3, (short)4), (read.Items![1]!.Id, read.Items[1]!.Amount));
        }

        [TestMethod]
        public void NumbersAreWrittenAndReadTheSameWhateverTheCulture()
        {
            var culture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            culture.NumberFormat.NumberDecimalSeparator = ",";
            culture.NumberFormat.NegativeSign = "~";
            var previous = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = culture;
            try
            {
                var line = Serializer.Serialize(new StatPacket { Hp = -5, HpMaximum = 1.5, Mp = 3, MpMaximum = 2.25, Option = 1 });
                var read = (StatPacket)Deserializer.Deserialize("stat -7 2.5 3 4.75 0 1");

                Assert.AreEqual("stat -5 1.5 3 2.25 0 1", line);
                Assert.AreEqual((-7, 2.5, 4.75), (read.Hp, read.HpMaximum, read.MpMaximum));
            }
            finally
            {
                CultureInfo.CurrentCulture = previous;
            }
        }

        [TestMethod]
        public void AnUnknownInjectedPacketKeepsItsBodyAfterTheHash()
        {
            var unresolved = (UnresolvedPacket)Deserializer.Deserialize("#unknown_probe^1^2");

            Assert.AreEqual(("unknown_probe", "1^2"), (unresolved.Header, unresolved.Body));
        }
    }

    [PacketHeader("joined_list_probe", Scope.InGame)]
    public class JoinedListProbePacket : PacketBase
    {
        [PacketListIndex(0, ListSeparator = "|")]
        public List<JoinedListProbeSubPacket?>? Items { get; set; }
    }

    public class JoinedListProbeSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Id { get; set; }

        [PacketIndex(1)]
        public short Amount { get; set; }
    }
}
