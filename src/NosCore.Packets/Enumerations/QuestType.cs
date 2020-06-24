//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace NosCore.Packets.Enumerations
{
    public enum QuestType : short
    {
        Hunt = 1,
        SpecialCollect = 2,
        CollectInRaid = 3,
        Brings = 4,
        CaptureWithoutGettingTheMonster = 5,
        Capture = 6,
        TimesSpace = 7,
        Product = 8,
        NumberOfKill = 9,
        TargetReput = 10,
        TsPoint = 11,
        Dialog1 = 12,
        CollectInTs = 13, //Collect in TimeSpace
        Required = 14,
        Wear = 15,
        Needed = 16,
        Collect = 17, // Collect basic items & quests items
        TransmitGold = 18,
        GoTo = 19,
        CollectMapEntity = 20, // Collect from map entity ( Ice Flower / Water )
        Use = 21,
        Dialog2 = 22,
        UnKnow = 23,
        Inspect = 24,
        WinRaid = 25,
        FlowerQuest = 26,
    }
}
