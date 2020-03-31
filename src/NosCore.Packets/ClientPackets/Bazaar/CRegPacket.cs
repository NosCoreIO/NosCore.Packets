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

namespace NosCore.Packets.ClientPackets.Bazaar
{
    [PacketHeader("c_reg", BlockedByTrading = true)]
    public class CRegPacket : PacketBase
    {
        [PacketIndex(0)] public int Type { get; set; }

        [PacketIndex(1)]
        [Range((byte) PocketType.Equipment, (byte) PocketType.Equipment)]
        public PocketType Inventory { get; set; }

        [PacketIndex(2)] public byte Slot { get; set; }
        [PacketIndex(3)] public int Unknown1 { get; set; }
        [PacketIndex(4)] public int Unknown2 { get; set; }
        [PacketIndex(5)] [Range(0, 4)] public byte Durability { get; set; }
        [PacketIndex(6)] public bool IsPackage { get; set; }

        [PacketIndex(7)]
        [Range(1, short.MaxValue)]
        public short Amount { get; set; }

        [PacketIndex(8)]
        [Range(1, long.MaxValue)]
        public long Price { get; set; }

        [PacketIndex(9)] public int Taxe { get; set; }
        [PacketIndex(10)] public byte MedalUsed { get; set; }
    }
}