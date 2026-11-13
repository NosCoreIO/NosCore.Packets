//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Families
{
    public class FmiSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public FamilyQuestKind Kind { get; set; }

        [PacketIndex(1, SpecialSeparator = "|")]
        public short QuestId { get; set; }

        [PacketIndex(2, SpecialSeparator = "|")]
        public FamilyQuestState State { get; set; }

        // The progress while in progress; once completed, the completion date as yyyyMMdd, which the
        // client cuts into year, month and day.
        [PacketIndex(3, SpecialSeparator = "|")]
        public int Value { get; set; }

        // Shown as "(Total: n)" next to a mission.
        [PacketIndex(4, SpecialSeparator = "|")]
        public int TotalCompletions { get; set; }
    }
}
