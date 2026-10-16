//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using System.Collections.Generic;

namespace NosCore.Packets.ClientPackets.Mates
{
    // ptctl 1 2 <id> <x> <y> <id> <x> <y> <id> <speed>: where each mate following the player is, then one id and
    // speed (the first mate's in every recording).
    [PacketHeader("ptctl", Scope.InGame)]
    public class PtctlPacket : PacketBase
    {
        [PacketIndex(0)]
        public short MapType { get; set; }

        [PacketIndex(1)]
        public short Amount { get; set; }

        [PacketListIndex(2, Length = -1, SpecialSeparator = " ")]
        public List<PtctlSubPacket?>? Mates { get; set; }

        [PacketIndex(3)]
        public long VisualId { get; set; }

        [PacketIndex(4)]
        public short Speed { get; set; }
    }
}