//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum EventTimerState : sbyte
    {
        // Shown in a time-space's first room before its mission starts.
        Waiting = -1,
        Running = 0,
        Stopped = 1
    }
}
