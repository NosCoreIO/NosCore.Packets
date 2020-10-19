﻿//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using System.Collections.Generic;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("ta_rank")]
    public class TARankPacket : PacketBase, IWorldPacket
    {
        [PacketListIndex(0, SpecialSeparator = ".")]
        public List<TARankSubPacket?>? CharacterList { get; set; }
        /*Order of winners: SwordsmanFirst, SwordsmanSecond, SwordsmanThird, ArcherFirst, ArcherSecond, ArcherThird, MageFirst, MageSecond, MageThird,
        MartialArtistFirst, MartialArtistSecond, MartialArtistThird, SwordsmanLastWinner, ArcherLastWinner, MageLastWinner, MartialArtistLastWinner.*/

        [PacketIndex(16)]
        public string? Date { get; set; } // yyMMddhhmm
    }
}