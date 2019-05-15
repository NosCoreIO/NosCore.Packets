using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ServerPackets.UI
{
    [PacketHeader("ta_rank")]
    public class TARankPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public TARankSubPacket SwordsmanFirst { get; set; }

        [PacketIndex(1, SpecialSeparator = ".")]
        public TARankSubPacket SwordsmanSecond { get; set; }

        [PacketIndex(2, SpecialSeparator = ".")]
        public TARankSubPacket SwordsmanThird { get; set; }

        [PacketIndex(3, SpecialSeparator = ".")]
        public TARankSubPacket ArcherFirst { get; set; }

        [PacketIndex(4, SpecialSeparator = ".")]
        public TARankSubPacket ArcherSecond { get; set; }

        [PacketIndex(5, SpecialSeparator = ".")]
        public TARankSubPacket ArcherThird { get; set; }

        [PacketIndex(6, SpecialSeparator = ".")]
        public TARankSubPacket MageFirst { get; set; }

        [PacketIndex(7, SpecialSeparator = ".")]
        public TARankSubPacket MageSecond { get; set; }

        [PacketIndex(8, SpecialSeparator = ".")]
        public TARankSubPacket MageThird { get; set; }

        [PacketIndex(9, SpecialSeparator = ".")]
        public TARankSubPacket MartialArtistFirst { get; set; }

        [PacketIndex(10, SpecialSeparator = ".")]
        public TARankSubPacket MartialArtistSecond { get; set; }

        [PacketIndex(11, SpecialSeparator = ".")]
        public TARankSubPacket MartialArtistThird { get; set; }

        [PacketIndex(12, SpecialSeparator = ".")]
        public TARankSubPacket SwordsmanLastWinner { get; set; }

        [PacketIndex(13, SpecialSeparator = ".")]
        public TARankSubPacket ArcherLastWinner { get; set; }

        [PacketIndex(14, SpecialSeparator = ".")]
        public TARankSubPacket MageLastWinner { get; set; }

        [PacketIndex(15, SpecialSeparator = ".")]
        public TARankSubPacket MartialArtistLastWinner { get; set; }

        [PacketIndex(16)]
        public string Date { get; set; } // yyMMddhhmm
    }
}