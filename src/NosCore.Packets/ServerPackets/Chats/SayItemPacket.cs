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
using NosCore.Packets.Enumerations;
using NosCore.Packets.ServerPackets.Inventory;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("sayitem")]
    public class SayItemPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte OratorSlot { get; set; }

        /// <summary>
        /// Spaces should be replaced by '^'
        /// </summary>
        [PacketIndex(3, IsOptional = true)]
        public string? Message { get; set; }

        [PacketIndex(4, IsOptional = true, RemoveHash = true)]
        public IconInfoPacket? IconInfo { get; set; }

        [PacketIndex(5, IsOptional = true, RemoveHash = true)]
        public EInfoPacket? EquipmentInfo { get; set; }

        [PacketIndex(6, IsOptional = true, RemoveHash = true)]
        public SlInfoPacket? SlInfo { get; set; }

    }
}