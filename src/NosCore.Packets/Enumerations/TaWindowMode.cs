//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    // Opens, closes or refreshes the team arena scoreboard (ta_m) and team list (ta_p).
    public enum TaWindowMode : byte
    {
        Open = 0,
        Close = 1,
        Update = 2,
        Clock = 3
    }
}
