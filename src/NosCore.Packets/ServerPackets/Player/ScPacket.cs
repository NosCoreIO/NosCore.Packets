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

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("sc")]
    public class ScPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; }

        [PacketIndex(1)]
        public byte MainWeaponUpgrade { get; set; }

        [PacketIndex(2)]
        public int MinHit { get; set; }

        [PacketIndex(3)]
        public int MaxHit { get; set; }

        [PacketIndex(4)]
        public int HitRate { get; set; }

        [PacketIndex(5)]
        public short CriticalHitRate { get; set; }

        [PacketIndex(6)]
        public int CriticalHitMultiplier { get; set; }

        [PacketIndex(7)]
        public byte Type2 { get; set; }

        [PacketIndex(8)]
        public short SecondaryWeaponUpgrade { get; set; }

        [PacketIndex(9)]
        public short SecondaryMinHit { get; set; }

        [PacketIndex(10)]
        public short SecondaryMaxHit { get; set; }

        [PacketIndex(11)]
        public short SecondaryHitRate { get; set; }

        [PacketIndex(12)]
        public short SecondaryCriticalHitRate { get; set; }

        [PacketIndex(13)]
        public short SecondaryCriticalHitMultiplier { get; set; }

        [PacketIndex(14)]
        public byte ArmorUpgrade { get; set; }

        [PacketIndex(15)]
        public short Defence { get; set; }

        [PacketIndex(16)]
        public short DefenceRate { get; set; }

        [PacketIndex(17)]
        public short DistanceDefence { get; set; }

        [PacketIndex(18)]
        public short DistanceDefenceRate { get; set; }

        [PacketIndex(19)]
        public short MagicalDefence { get; set; }

        [PacketIndex(20)]
        public short FireResistance { get; set; }

        [PacketIndex(21)]
        public short WaterResistance { get; set; }

        [PacketIndex(22)]
        public short LightResistance { get; set; }

        [PacketIndex(23)]
        public short DarkResistance { get; set; }
    }
}