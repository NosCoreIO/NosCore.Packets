//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Families
{
    // The Update button of the family warehouse history window.
    [PacketHeader("fslog_cts", Scope.InGame)]
    public class FslogCtsPacket : PacketBase
    {
    }
}
