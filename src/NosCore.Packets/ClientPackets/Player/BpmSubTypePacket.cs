//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Player
{
    public  class BpmSubTypePacket : PacketBase
    {
        [PacketIndex(0)]
        public long QuestId { get; set; }

        [PacketIndex(1, SpecialSeparator = " ")]
        public MissionType MissionType { get; set; }

        [PacketIndex(2, SpecialSeparator = " ")]
        public FrequencyType FrequencyType { get; set; }

        [PacketIndex(3, SpecialSeparator = " ")]
        public long Advancement { get; set; }

        [PacketIndex(4, SpecialSeparator = " ")]
        public long MaxObjectiveValue { get; set; }

        [PacketIndex(5, SpecialSeparator = " ")]
        public byte Reward { get; set; }

        [PacketIndex(6, SpecialSeparator = " ")]
        public long MissionMinutesRemaining { get; set; }
    }
}
