//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Quest
{
    public class QuestSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte ObjectiveCount { get; set; }

        [PacketIndex(1)]
        public short QuestId { get; set; }

        [PacketIndex(2)]
        public short InfoId { get; set; }

        [PacketIndex(3)]
        public QuestType GoalType { get; set; }

        [PacketListIndex(4, ListSeparator = ".")]
        public List<QuestObjectiveSubPacket>? QuestObjectiveSubPackets { get; set; }

        [PacketIndex(5)]
        public bool ShowDialog { get; set; }
    }
}