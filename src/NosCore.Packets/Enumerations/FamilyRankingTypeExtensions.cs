//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public static class FamilyRankingTypeExtensions
    {
        public static FamilyRankingTab Tab(this FamilyRankingType type) => type switch
        {
            FamilyRankingType.LastMonthExperience or FamilyRankingType.LastMonthAngels or FamilyRankingType.LastMonthDemons => FamilyRankingTab.Monthly,
            FamilyRankingType.DailyExperience or FamilyRankingType.DailyReputation => FamilyRankingTab.More,
            FamilyRankingType.SpireCatacombs => FamilyRankingTab.SpireCatacombs,
            _ => FamilyRankingTab.Current
        };
    }
}
