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
    // Fills whichever tab of the family ranking the client last asked for with frank_cts.
    [PacketHeader("frank_stc", Scope.InGame)]
    public class FrankStcPacket : PacketBase
    {
        [PacketListIndex(0)]
        public List<FrankStcSubPacket?>? Entries { get; set; }
    }
}
