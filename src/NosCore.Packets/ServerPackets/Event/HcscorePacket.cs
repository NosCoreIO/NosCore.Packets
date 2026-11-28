//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Event
{
    // The damage ranking shown when a raid boss dies: at most three players, highest damage first.
    [PacketHeader("hcscore", Scope.InGame)]
    public class HcscorePacket : PacketBase
    {
        [PacketListIndex(0)]
        public List<HcscoreSubPacket?>? Ranking { get; set; }
    }
}
