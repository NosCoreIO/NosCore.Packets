//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    // The line the battle search window shows under its title.
    public enum BsInfoText : byte
    {
        WaitForEntry = 0,
        SearchOpposingTeam = 1,
        OpposingTeamFound = 2,
        NoOpposingTeamFound = 3,
        RegistrationRejected = 4,
        SearchTeammates = 5,
        TeammatesFound = 6,
        NoTeammatesFound = 7,
        SearchTeammatesAgain = 8
    }
}
