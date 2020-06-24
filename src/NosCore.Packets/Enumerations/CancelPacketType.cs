//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum CancelPacketType
    {
        CancelCast =
            0, //Casting is the status after using an skill. The client waits until x packet/s appear, until then it blocks the movement)
        CancelPicking = 1, //Needs to be verified

        CancelAutoAttack =
            2 //Changes AutoAttack to Selected. AutoAttack = Red arrow on top of the enemy. Selected = Yellow arrow.
    }
}