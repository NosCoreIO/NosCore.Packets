//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum QuestRewardType : short
    {
        None = 0,
        Gold = 1,
        GoldPerMonster = 2,
        Experience = 3,
        ExperiencePerMonster = 4,
        JobExperience = 5,
        ConsecutiveItem = 6,
        EtcMainItem = 7,
        WearItem = 8,
        Reputation = 9,
        GoldPerKill = 10,
        ExperiencePerKill = 11,
        JobExperiencePerKill = 12,
        NotRepeatable = 13,
        ClassItem = 14,
        HeroExperience = 15,
        Level = 17,
        LevelAndJobLevel = 18
    }
}
