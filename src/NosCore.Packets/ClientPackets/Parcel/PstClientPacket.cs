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

namespace NosCore.Packets.ClientPackets.Parcel
{
    [PacketHeader("pst")]
    public class PstClientPacket : PacketBase
    {
        [PacketIndex(0)] public int ActionType { get; set; }

        [PacketIndex(1)] public int Type { get; set; }

        [PacketIndex(2)] public long Id { get; set; }

        [PacketIndex(3)] public int? Unknow1 { get; set; }

        [PacketIndex(4)] public int Unknow2 { get; set; }

        [PacketIndex(5)] public string? ReceiverName { get; set; }

        [PacketIndex(6, IsOptional = true)] public string? Title { get; set; }

        [PacketIndex(7, IsOptional = true)] public string? Text { get; set; }
    }
}