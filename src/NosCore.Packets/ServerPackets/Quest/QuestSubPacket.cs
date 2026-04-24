//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{
    /// <summary>
    /// Flat quest entry used by <see cref="QstlistPacket"/> and <see cref="QstiPacket"/>.
    /// On the wire it is a 16-field dotted tuple:
    /// <c>&lt;slot&gt;.&lt;questId&gt;.&lt;questLineId&gt;.&lt;type&gt;.&lt;obj1Cur&gt;.&lt;obj1Req&gt;.&lt;status&gt;.&lt;obj2Cur&gt;.&lt;obj2Req&gt;.&lt;obj3Cur&gt;.&lt;obj3Req&gt;.&lt;obj4Cur&gt;.&lt;obj4Req&gt;.&lt;obj5Cur&gt;.&lt;obj5Req&gt;.&lt;showInfo&gt;</c>.
    /// </summary>
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
