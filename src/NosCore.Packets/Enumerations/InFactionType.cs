//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    // The faction drawn over a player only on Act 4 maps; everywhere else the field is None.
    public enum InFactionType : byte
    {
        None = 0,
        Angel = 3,
        Demon = 4
    }
}
