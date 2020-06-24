//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum RequestExchangeType : byte
    {
        Requested = 1,
        List = 2,
        Confirmed = 3,
        Cancelled = 4,
        Declined = 5
    }
}