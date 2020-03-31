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

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("pdti")]
    public class PdtiPacket : PacketBase
    {
        [PacketIndex(0)] public short Unknow { get; set; } // TODO find this - type 10 and 11

        [PacketIndex(1)] public long ItemVnum { get; set; }

        [PacketIndex(2)] public short RecipeAmount { get; set; } // TODO review this - type 1 and Recipe Amount

        [PacketIndex(3)] public short Unknow3 { get; set; } // TODO find this - type 26 and 27

        [PacketIndex(4)] public short ItemUpgrade { get; set; }

        [PacketIndex(5)] public short Unknow4 { get; set; } // TODO find this - always 0
    }
}