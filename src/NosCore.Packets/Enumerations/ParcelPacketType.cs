//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

namespace NosCore.Packets.Enumerations
{
    public enum ParcelPacketType : byte
    {
        Listed = 1,
        Received = 2,
        NotEnoughSpace = 5,
        Deleted = 7
    }
}
