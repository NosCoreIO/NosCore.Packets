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
    // suctl <map id> <amount> then <mate id> <target type> <target id> for each mate sent at the target.
    [PacketHeader("suctl", Scope.InGame)]
    public class SuCtlPacket : PacketBase
    {
        [PacketIndex(0)]
        public short MapId { get; set; }

        [PacketIndex(1)]
        public byte Amount { get; set; }

        [PacketListIndex(2, Length = -1, SpecialSeparator = " ")]
        public List<SuCtlSubPacket?>? Mates { get; set; }
    }
}
