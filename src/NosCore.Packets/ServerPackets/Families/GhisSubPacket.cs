//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    // Which arguments an entry carries, and what they mean, depends on Type; the ones it
    // does not use stay null and leave no gap.
    public class GhisSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public FamilyLogType Type { get; set; }

        [PacketIndex(1, SpecialSeparator = "|", IsOptional = true)]
        public string? FirstArgument { get; set; }

        [PacketIndex(2, SpecialSeparator = "|", IsOptional = true)]
        public string? SecondArgument { get; set; }

        [PacketIndex(3, SpecialSeparator = "|", IsOptional = true)]
        public string? ThirdArgument { get; set; }

        [PacketIndex(4, SpecialSeparator = "|", IsOptional = true)]
        public string? FourthArgument { get; set; }

        [PacketIndex(5, SpecialSeparator = "|")]
        public int HoursAgo { get; set; }
    }
}
