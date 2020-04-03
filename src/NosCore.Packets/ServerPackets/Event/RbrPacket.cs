//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("rbr")]
    public class RbrPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public RbrSubPacketBasicInfo? TsBasicInfo { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; }

        [PacketIndex(2)]
        public bool Completed { get; set; }

        [PacketIndex(3)]
        public RbrSubPacketMinMaxLevel? MinMaxLevel { get; set; }

        [PacketIndex(4)]
        public short RequiredSeeds { get; set; }

        [PacketListIndex(5)]
        public List<RbrSubPacketItem?>? DrawRewards { get; set; } //Length = 5

        [PacketListIndex(6)]
        public List<RbrSubPacketItem?>? SpecialRewards { get; set; } //Length = 2

        [PacketListIndex(7)]
        public List<RbrSubPacketItem?>? BonusRewards { get; set; } //Length = 3

        [PacketIndex(8, SpecialSeparator = ".")]
        public RbrSubPacketHighScore? HighScore { get; set; }

        [PacketIndex(9)]
        public bool IsHidden { get; set; }

        [PacketIndex(10)]
        public bool LoserMode { get; set; }

        [PacketIndex(11, SpecialSeparator = "\n")]
        public RbrSubPacketTitleAndDescription? TitleAndDescription { get; set; }
    }
}
