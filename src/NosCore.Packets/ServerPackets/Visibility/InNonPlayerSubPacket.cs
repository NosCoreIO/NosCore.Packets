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

namespace NosCore.Packets.ServerPackets.Visibility
{
    public class InNonPlayerSubPacket : PacketBase
    {
        [PacketIndex(1)]
        public InAliveSubPacket? InAliveSubPacket { get; set; }

        [PacketIndex(2)]
        public short Dialog { get; set; }

        [PacketIndex(3)]
        public byte Faction { get; set; }

        [PacketIndex(4)]
        
        public short GroupEffect { get; set; }

        [PacketIndex(5)]
        public long? Owner { get; set; }

        [PacketIndex(6)]
        public SpawnEffectType SpawnEffect { get; set; }

        [PacketIndex(7)]
        public bool IsSitting { get; set; }

        [PacketIndex(8)]
        public short? Morph { get; set; }

        [PacketIndex(9)]
        public string? Name { get; set; }

        [PacketIndex(10)]
        public byte Unknow1 { get; set; }

        [PacketIndex(11)]
        public short? Unknow2 { get; set; }

        [PacketIndex(12)]
        public byte Unknow3 { get; set; }

        [PacketIndex(13)]
        public short Skill1 { get; set; }

        [PacketIndex(14)]
        public short Skill2 { get; set; }

        [PacketIndex(15)]
        public short Skill3 { get; set; }

        [PacketIndex(16)]
        public short SkillRank1 { get; set; }

        [PacketIndex(17)]
        public short SkillRank2 { get; set; }

        [PacketIndex(18)]
        public short SkillRank3 { get; set; }

        [PacketIndex(19)]
        public byte Unknow4 { get; set; }
    }
}