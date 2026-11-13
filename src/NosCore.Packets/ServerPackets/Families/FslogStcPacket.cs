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
        // -1 makes the client empty the window before adding the entries; any other value
        // is read as one more entry and appends to what the window already shows.
        [PacketIndex(0)]
        public int Reset { get; set; } = -1;

        [PacketListIndex(1)]
        public List<FslogStcSubPacket?>? Entries { get; set; }
    }
}
