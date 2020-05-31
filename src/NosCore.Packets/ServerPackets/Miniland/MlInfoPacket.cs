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

namespace NosCore.Packets.ServerPackets.Miniland
{
    [PacketHeader("mlinfo")]
    public class MlinfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public short WelcomeMusicInfo { get; set; } = 3800;

        [PacketIndex(1)]
        public long MinilandPoint { get; set; }

        [PacketIndex(2)]
        public byte Unknown2 { get; set; }

        [PacketIndex(3)]
        public int DailyVisitCount { get; set; }

        [PacketIndex(4)]
        public int VisitCount { get; set; }

        [PacketIndex(5)]
        public byte Unknown3 { get; set; }

        [PacketIndex(6)]
        public MinilandState MinilandState { get; set; }

        [PacketIndex(7)] 
        public short WelcomeMusicInfo2 { get; set; } = 3800;

        [PacketIndex(8)] 
        public Game18NConstString MinilandWelcomeMessage { get; set; } = Game18NConstString.Welcome;
    }
}