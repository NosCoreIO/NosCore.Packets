//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Arena
{
    // HP and MP bars of the team arena list, in the same slot order as ta_p.
    [PacketHeader("ta_ps", Scope.InGame)]
    public class TaPsPacket : PacketBase
    {
        [PacketListIndex(0)]
        public List<TaPsSubPacket?>? Fighters { get; set; }
    }
}
