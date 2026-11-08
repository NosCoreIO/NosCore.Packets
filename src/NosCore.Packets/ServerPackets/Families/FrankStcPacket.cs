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
        // The tab the entries fill; the client reads the first entry as this when it is missing.
        [PacketIndex(0)]
        public FamilyRankingType Type { get; set; }

        [PacketListIndex(1)]
        public List<FrankStcSubPacket?>? Entries { get; set; }
    }
}
