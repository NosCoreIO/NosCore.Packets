//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum RlPacketType
    {
        Normal,
        WantToRegister = 1,
        WantToUnregister = 2,
        MemberAndAlreadyInList = 3
    }
}