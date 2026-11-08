//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Enumerations
{
    // Being dead, in a shop or in an exchange are not here: those already refuse every packet
    // whose Scope does not admit them.
    [Flags]
    public enum SenderState
    {
        None = 0,
        Alive = 1,
        Vehicled = 2,
        Transformed = 4
    }
}
