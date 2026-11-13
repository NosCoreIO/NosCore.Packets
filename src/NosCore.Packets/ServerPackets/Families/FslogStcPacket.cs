//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------
using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    // The family warehouse history window, newest entry first.
    [PacketHeader("fslog_stc", Scope.InGame)]
    public class FslogStcPacket : PacketBase
    {
        // Must stay -1: it makes the client empty the window before adding the entries.
        // The client reads any other value as the first entry, and appending to the window
        // is not supported here since the whole history is always sent at once.
        [PacketIndex(0)]
        public int Reset { get; set; } = -1;

        [PacketListIndex(1)]
        public List<FslogStcSubPacket?>? Entries { get; set; }
    }
}
