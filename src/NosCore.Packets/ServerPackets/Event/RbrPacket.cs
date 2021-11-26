//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Event
{
    [PacketHeader("rbr", Scope.InGame)]
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

        [PacketListIndex(5, Length = 5)]
        public List<RbrSubPacketItem?>? DrawRewards { get; set; }

        [PacketListIndex(6, Length = 2)]
        public List<RbrSubPacketItem?>? SpecialRewards { get; set; }

        [PacketListIndex(7, Length = 3)]
        public List<RbrSubPacketItem?>? BonusRewards { get; set; }

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
