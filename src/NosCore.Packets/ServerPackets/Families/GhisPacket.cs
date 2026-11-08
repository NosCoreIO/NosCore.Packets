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
    // The family history window, answering fhis_cts.
    [PacketHeader("ghis", Scope.InGame)]
    public class GhisPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; }

        [PacketListIndex(1)]
        public List<GhisSubPacket?>? Entries { get; set; }
    }
}
