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

namespace NosCore.Packets.ServerPackets.Parcel
{
    [PacketHeader("post")]
    public class PostPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte PostType { get; set; }

        [PacketIndex(2)]
        public short Id { get; set; }

        [PacketIndex(3)]
        public short Unknown { get; set; }

        [PacketIndex(4)]
        public bool IsOpened { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public PostSubPacket? PostSubPacket { get; set; }

        [PacketIndex(6, IsOptional = true)]
        public string? DateTime { get; set; }

        [PacketIndex(7)]
        public string? SenderName { get; set; }

        [PacketIndex(8)]
        public string? Title { get; set; }

        [PacketIndex(9, IsOptional = true)]
        public string? Message { get; set; }
    }
}