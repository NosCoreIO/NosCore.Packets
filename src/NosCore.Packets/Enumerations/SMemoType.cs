//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum SMemoType : byte
    {
        SuccessNpc = 0,
        SuccessPlayer = 1,
        FailNpc = 2,
        FailPlayer = 3,
        BankSuccess = 4,
        BankError = 5,
        BankNormal = 6
    }
}