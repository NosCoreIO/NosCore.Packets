//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{
    public class QuestSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte QuestSlot { get; set; }

        [PacketIndex(1)]
        public short QuestId { get; set; }

        [PacketIndex(2)]
        public short QuestLineId { get; set; }

        [PacketIndex(3)]
        public QuestType QuestType { get; set; }

        [PacketIndex(4)]
        public short Objective1Current { get; set; }

        [PacketIndex(5)]
        public short Objective1Required { get; set; }

        [PacketIndex(6)]
        public byte Status { get; set; }

        [PacketIndex(7)]
        public short Objective2Current { get; set; }

        [PacketIndex(8)]
        public short Objective2Required { get; set; }

        [PacketIndex(9)]
        public short Objective3Current { get; set; }

        [PacketIndex(10)]
        public short Objective3Required { get; set; }

        [PacketIndex(11)]
        public short Objective4Current { get; set; }

        [PacketIndex(12)]
        public short Objective4Required { get; set; }

        [PacketIndex(13)]
        public short Objective5Current { get; set; }

        [PacketIndex(14)]
        public short Objective5Required { get; set; }

        [PacketIndex(15)]
        public bool QuestToShowInfo { get; set; }
    }
}
