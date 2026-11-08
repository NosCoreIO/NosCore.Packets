//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    // Answers today_cts and lets the client open the daily message box.
    [PacketHeader("today_stc", Scope.InGame)]
    public class TodayStcPacket : PacketBase
    {
    }
}
