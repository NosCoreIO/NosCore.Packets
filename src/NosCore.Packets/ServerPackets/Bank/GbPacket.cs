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

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Bank
{
    [PacketHeader("gb")]
    public class GbPacket : PacketBase
    {
        [PacketIndex(0)]
        public BankActionType Type { get; set; }

        [PacketIndex(1)]
        [Range(0, long.MaxValue)]
        public long GoldBank { get; set; }

        [PacketIndex(2)]
        [Range(0, int.MaxValue)]
        public int Gold { get; set; }

        [PacketIndex(3)]
        public BankRankType BankRank { get; set; }

        [PacketIndex(4)]
        [Range(0, int.MaxValue)]
        public int BankTax { get; set; }
    }
}
