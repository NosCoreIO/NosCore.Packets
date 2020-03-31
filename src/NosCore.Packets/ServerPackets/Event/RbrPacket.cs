using System.Collections.Generic;
using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("rbr")]
    public class RbrPacket : PacketBase
    {
        [PacketIndex(0, SpecialSeparator = ".")]
        public RbrSubPacketBasicInfo? TsBasicInfo { get; set; }

        [PacketIndex(1)]
        public byte Unknown { get; set; }

        [PacketIndex(2)]
        public bool Completed { get; set; }

        [PacketIndex(3)]
        public RbrSubPacketMinMaxLevel? MinMaxLevel { get; set; }

        [PacketIndex(4)]
        public short RequiredSeeds { get; set; }

        [PacketIndex(5)]
        public List<RbrSubPacketItem?>? DrawRewards { get; set; } //Length = 5

        [PacketIndex(6)]
        public List<RbrSubPacketItem?>? SpecialRewards { get; set; } //Length = 2

        [PacketIndex(7)]
        public List<RbrSubPacketItem?>? BonusRewards { get; set; } //Length = 3

        [PacketIndex(8, SpecialSeparator = ".")]
        public RbrSubPacketHighScore? HighScore { get; set; }

        [PacketIndex(9)]
        public bool IsHidden { get; set; }

        [PacketIndex(10)]
        public bool LoserMode { get; set; }

        [PacketIndex(11, SpecialSeparator = "\n")]
        public RbrSubPacketTitleAndDescription? TitleAndDescription { get; set; }
    }
}
