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

using System;
using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Login
{
    [PacketHeader("NoS0575", AnonymousAccess = true)]
    public class NoS0575Packet : PacketBase
    {
        [PacketIndex(0)]
        public int SessionId { get; set; }

        [PacketIndex(1)]
        public string? Username { get; set; }

        [PacketIndex(2)]
        public string? Password { get; set; }

        [PacketIndex(3)]
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Seems to always be 00564F36 (random value converted to HEX)
        /// Would be better if we could provide some kind of HEX serialization instead of using string
        /// it may be the update version number
        /// </summary>
        [PacketIndex(3)]
        public string? UnknownYet { get; set; }

        [PacketIndex(4)]
        public ClientVersionSubPacket? ClientVersion { get; set; }

        [PacketIndex(5)]
        [Range(0, 0)]
        public byte UnknownConstant { get; set; }

        /// <summary>
        /// The MD5 string is a MD5 hashing : MD5_STRING(MD5_FILE(NostaleXClient.exe) + MD5_FILE(NostaleClient.exe))
        /// </summary>
        [PacketIndex(6)]
        public string? Md5String { get; set; }
    }
}