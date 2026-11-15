//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.RainbowBattle
{
    // The member list of the receiver's Rainbow Battle team.
    [PacketHeader("fblst", Scope.InGame)]
    public class FblstPacket : PacketBase
    {
        [PacketListIndex(0, SpecialSeparator = ".")]
        public List<FblstSubPacket?>? Members { get; set; }
    }
}
