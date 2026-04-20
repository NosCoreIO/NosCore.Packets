//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    // Family action log message. Amount is the number of log entries in Body, Body is
    // the pre-rendered space-joined entry payload (OpenNos keeps it opaque so it can
    // pack arbitrarily many log rows without re-encoding).
    [PacketHeader("fslog_stc", Scope.InGame)]
    public class FslogStcPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Amount { get; set; }

        [PacketIndex(1)]
        public string? Body { get; set; }
    }
}
