//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets
{
    // An item sent with a negative vnum is a limited one: the client shows "(Limited)" after its name.
    // -1 stays the empty-slot vnum.
    internal static class LimitedItem
    {
        public static short ToWire(short vnum, bool isLimited) => isLimited && vnum > 0 ? (short)-vnum : vnum;

        public static bool IsLimited(short wire) => wire < -1;

        public static short VNum(short wire) => wire < -1 ? (short)-wire : wire;
    }
}
