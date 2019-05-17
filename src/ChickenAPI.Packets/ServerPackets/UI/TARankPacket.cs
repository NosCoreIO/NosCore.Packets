using ChickenAPI.Packets.Attributes;
using System.Collections.Generic;

namespace ChickenAPI.Packets.ServerPackets.UI
{
    [PacketHeader("ta_rank")]
    public class TARankPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public List<TARankSubPacket> CharacterList { get; set; }
        /*Order of winners: SwordsmanFirst, SwordsmanSecond, SwordsmanThird, ArcherFirst, ArcherSecond, ArcherThird, MageFirst, MageSecond, MageThird,
        MartialArtistFirst, MartialArtistSecond, MartialArtistThird, SwordsmanLastWinner, ArcherLastWinner, MageLastWinner, MartialArtistLastWinner.*/

        [PacketIndex(16)]
        public string Date { get; set; } // yyMMddhhmm
    }
}