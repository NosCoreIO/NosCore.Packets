//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Player
{
    public  class BpmSubTypePacket : PacketBase
    {
        [PacketIndex(0)]
        public short MissionSubType { get; set; } // todo : to enum

        [PacketIndex(1)]
        public short MissionType { get; set; } // todo : to enum

        [PacketIndex(2)]
        public long Advencement { get; set; }

        [PacketIndex(3)]
        public long MaxObjectiveValue { get; set; }

        [PacketIndex(4)]
        public byte Reward { get; set; }

        [PacketIndex(5)]
        public long MissionMinutesRemaining { get; set; }
    }
}
