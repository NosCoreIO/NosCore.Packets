//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System;

namespace NosCore.Packets.Enumerations
{
    [Flags]
    public enum Scope
    {
        Unknown = 0,
        OnCharacterScreen = 1,
        InTrade = 2,
        InGame = 4,
        OnLoginScreen = 8,
    }
}