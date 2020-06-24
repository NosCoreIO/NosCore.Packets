//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum LoginFailType : byte
    {
        OldClient = 1,
        UnhandledError = 2,
        Maintenance = 3,
        AlreadyConnected = 4,
        AccountOrPasswordWrong = 5,
        CantConnect = 6,
        Banned = 7,
        WrongCountry = 8,
        WrongCaps = 9
    }
}