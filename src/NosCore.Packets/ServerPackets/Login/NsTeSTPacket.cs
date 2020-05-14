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
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("NsTeST")]
    public class NsTestPacket : PacketBase
    {
        [PacketIndex(0)]
        public RegionType RegionType { get; set; }

        [PacketIndex(1)]
        public string? AccountName { get; set; }

        //this seems to be always 2 in case of new auth and null else
        [PacketIndex(2, IsOptional = true)]
        public int? Unknown { get; set; }

        [PacketIndex(3)]
        public int SessionId { get; set; }


        [PacketListIndex(4)]
        public List<NsTeStSubPacket?>? SubPacket { get; set; }
    }
}