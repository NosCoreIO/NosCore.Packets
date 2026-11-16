//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.TimeSpaces
{
    // The time-space room's objective line, shown in the mission panel; an empty one clears it.
    [PacketHeader("sinfo", Scope.InGame)]
    public class SinfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}
