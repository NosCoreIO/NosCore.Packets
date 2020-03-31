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
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_blist")]
    public class CBListPacket : PacketBase
    {
        [PacketIndex(0)] public int Index { get; set; }

        [PacketIndex(1)] public BazaarListType TypeFilter { get; set; }

        [PacketIndex(2)] public byte SubTypeFilter { get; set; }

        [PacketIndex(3)] public byte LevelFilter { get; set; }

        [PacketIndex(4)] public byte RareFilter { get; set; }

        [PacketIndex(5)] public byte UpgradeFilter { get; set; }

        [PacketIndex(6)] public byte OrderFilter { get; set; }

        [PacketIndex(7)] public byte Unknown1 { get; set; }

        [PacketIndex(8)] public List<short>? ItemVNumFilter { get; set; }
    }
}