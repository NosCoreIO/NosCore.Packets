//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    // The line an item tooltip shows about trading it.
    public enum TradeRestriction : byte
    {
        None = 0,
        TradableUntilEquipped = 1,
        NotTradable = 2
    }
}
