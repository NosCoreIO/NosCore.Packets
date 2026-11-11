//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum FamilyRankingType : byte
    {
        // Current Rankings tab.
        Experience = 0,
        MonthlyExperience = 1,
        CurrentAngels = 2,
        CurrentDemons = 3,

        // Monthly Rankings tab: last month's results.
        LastMonthExperience = 4,
        LastMonthAngels = 6,
        LastMonthDemons = 7,

        // More tab: rankings refreshed once a day.
        DailyExperience = 8,
        DailyReputation = 9,

        SpireCatacombs = 10
    }
}
