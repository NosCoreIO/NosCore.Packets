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

namespace NosCore.Packets.Enumerations
{
    public enum CharacterDignity : byte
    {
        Basic = 1, // Basic Dignity ( Dignity are not changed )
        Suspected = 2, // Suspected RANK  (Dignity: -100 ~ -200)
        BluffedNameOnly = 3, // Bluffed name only RANK (Dignity: -201 ~ -400)
        NotQualifiedFor = 4, // Not qualified for RANK (Dignity: -401 ~ -600)
        Useless = 5, // Useless RANK (Dignity: -601 ~ -800)
        StupidMinded = 6 // Stupid minded RANK (Dignity: -801 ~ -1.000)
    }
}