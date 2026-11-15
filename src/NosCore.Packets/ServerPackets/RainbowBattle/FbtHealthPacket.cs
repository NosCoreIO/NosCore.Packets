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
    // The HP and MP bars of the receiver's teammates; the client matches each entry to a member by id.
    [PacketHeader("fbt", Scope.InGame, AllowDuplicateHeader = true)]
    public class FbtHealthPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Type { get; set; } = 3;

        [PacketListIndex(1, SpecialSeparator = ".")]
        public List<FbtHealthSubPacket?>? Members { get; set; }
    }
}
