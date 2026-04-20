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
    // Tells the client which skills the character currently has on its bar. Sent on
    // login, class change, SP activation/deactivation, and anywhere the skill list
    // changes. Format mirrors OpenNos Character.GenerateSki:
    //   ski {primaryVnum} {secondaryVnum} {skillVnum1} {skillVnum2} ...
    //
    // primary/secondary default to the class's two starter skill vnums (200 + 20*Class,
    // 201 + 20*Class) when SP is inactive; under SP they fall back to the first skill.
    // Without this packet the client doesn't know what the player can cast, so the
    // cooldown gate in UseSkillPacketHandler is effectively mute.
    [PacketHeader("ski", Scope.InGame)]
    public class SkiPacket : PacketBase
    {
        [PacketIndex(0)]
        public short PrimarySkillVnum { get; set; }

        [PacketIndex(1)]
        public short SecondarySkillVnum { get; set; }

        [PacketListIndex(2, ListSeparator = " ", IsOptional = true)]
        public List<short>? SkillVnums { get; set; }
    }
}
