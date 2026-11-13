//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Quest
{
    // The reward window. An unused slot is sent as 0 0 0. Only gold rewards print their amount; item rewards show
    // the item and its count, the others only their icon.
    [PacketHeader("qr", Scope.InGame)]
    public class QrPacket : PacketBase
    {
        [PacketIndex(0)]
        public QuestRewardType Reward1Type { get; set; }

        [PacketIndex(1)]
        public int Reward1Data { get; set; }

        [PacketIndex(2)]
        public int Reward1Amount { get; set; }

        [PacketIndex(3)]
        public QuestRewardType Reward2Type { get; set; }

        [PacketIndex(4)]
        public int Reward2Data { get; set; }

        [PacketIndex(5)]
        public int Reward2Amount { get; set; }

        [PacketIndex(6)]
        public QuestRewardType Reward3Type { get; set; }

        [PacketIndex(7)]
        public int Reward3Data { get; set; }

        [PacketIndex(8)]
        public int Reward3Amount { get; set; }

        [PacketIndex(9)]
        public QuestRewardType Reward4Type { get; set; }

        [PacketIndex(10)]
        public int Reward4Data { get; set; }

        [PacketIndex(11)]
        public int Reward4Amount { get; set; }

        [PacketIndex(12)]
        public short QuestId { get; set; }
    }
}
