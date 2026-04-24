//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum SuPacketHitMode : sbyte
    {
        NoDamageFail = -2,
        NoDamageSuccess = -1,
        SuccessAttack = 0,
        Miss = 1,
        OutOfRange = 2,
        CriticalAttack = 3,
        MissAoe = 4,
        AttackedInAoe = 5,
        AttackedInAoeCrit = 6,
        ReflectionAoeMiss = 7
    }
}