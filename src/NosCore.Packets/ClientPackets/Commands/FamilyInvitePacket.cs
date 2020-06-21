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
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Commands
{
    [PacketHeader("%Familyinvite")]
    [PacketHeaderAlias("%Invitationdefamille", Flag = nameof(RegionType.FR))]
    [PacketHeaderAlias("%Familieneinladung", Flag = nameof(RegionType.DE))]
    [PacketHeaderAlias("%Invita", Flag = nameof(RegionType.IT))]
    [PacketHeaderAlias("%Invitación", Flag = nameof(RegionType.ES))]
    [PacketHeaderAlias("%Familyinvite", Flag = nameof(RegionType.PL))]
    [PacketHeaderAlias("%Пригласить-семья", Flag = nameof(RegionType.RU))]
    [PacketHeaderAlias("%Aileden", Flag = nameof(RegionType.TR))]
    [PacketHeaderAlias("%Rodina", Flag = nameof(RegionType.CS))]
    public class FamilyInvitePacket : PacketBase
    {
        [PacketIndex(0)]
        public string? CharacterName { get; set; }
    }
}