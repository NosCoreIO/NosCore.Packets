//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum RsfmPacketType : byte
    {
        Open = 0,

        // Sent after the score of a cleared run, with the grid size.
        Cleared = 1,

        // Sent with a room's mission text, before its timer starts, with an empty grid.
        RoomMissionStarted = 2
    }
}
