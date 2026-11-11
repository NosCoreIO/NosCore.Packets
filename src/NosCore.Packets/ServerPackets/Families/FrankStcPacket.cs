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
    [PacketHeader("frank_stc", Scope.InGame)]
    public class FrankStcPacket : PacketBase
    {
        // The client reads the first entry as the tab when this is missing.
        [PacketIndex(0)]
        public FamilyRankingTab Type { get; set; }

        [PacketListIndex(1)]
        public List<FrankStcSubPacket?>? Entries { get; set; }
    }
}
