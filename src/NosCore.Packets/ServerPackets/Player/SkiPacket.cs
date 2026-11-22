//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    // The character's skill list: the class's primary and secondary attack (under a
    // specialist, its first skill twice) followed by every skill it knows. The line opens
    // with a field the traces always show as 0; without it the client drops the first skill.
    [PacketHeader("ski", Scope.InGame)]
    public class SkiPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Unknown { get; set; }

        [PacketIndex(1)]
        public short PrimarySkillVnum { get; set; }

        [PacketIndex(2)]
        public short SecondarySkillVnum { get; set; }

        [PacketListIndex(3, ListSeparator = " ", IsOptional = true)]
        public List<short>? SkillVnums { get; set; }
    }
}
