//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum BankActionType : byte
    {
        OpenFromSavingsBook = 0,
        DepositGold = 1,
        WithdrawGold = 2,
        OpenBank = 3
    }
}
