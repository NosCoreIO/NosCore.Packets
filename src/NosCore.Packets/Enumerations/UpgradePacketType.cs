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
    public enum UpgradePacketType
    {
        ItemToPart = 0,
        UpgradeItem = 1, //  UpgradeMode.Normal, UpgradeProtection.None, hasAmulet: HasAmulet
        CellonItem = 3,
        RarifyItem = 7, // mode, protection
        SumResistance = 8,
        UpgradeSpNoProtection = 9, // UpgradeProtection.None
        UpgradeItemProtected = 20, // UpgradeMode.Normal, UpgradeProtection.Protected, hasAmulet: HasAmulet
        RarifyItemProtected = 21, // RarifyMode.Normal, RarifyProtection.Scroll
        UpgradeSpProtected = 25, // Scroll Blue or red - Need to verify
        UpgradeSpProtected2 = 26, // Scroll Blue or red - Need to verify
        UpgradeSpChiken = 35, // Scroll Chiken - event
        UpgradeSpPyjama = 38, // Scroll Pyjama - Event
        PerfectSp = 41,
        UpgradeSpPirate = 42, // Scroll Pirate - Event

        UpgradeItemGoldScroll =
            43, // UpgradeMode.Reduced, UpgradeProtection.Protected, hasAmulet: hasAmulet ( Gold scroll)
        CreateFairyZenas = 50,
        CreateFairyErenia = 51,
        CreateFairyFernon = 52,
        FusionItem = 53
    }
}