//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum WreqPacketType : byte
    {
        DailyTeamTimeSpaceEntry = 0, // Just sound wrong but idk
        InstanceEntry = 1,
        InstanceEntryLoserMode = 5,
        TeamTimeSpaceEntry = 3
    }
}
