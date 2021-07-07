//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("score", Scope.InGame)]
    public class ScorePacket : PacketBase
    {
        [PacketIndex(0)]
        public EndStateType EndState { get; set; }

        [PacketIndex(1)]
        public int Points { get; set; }

        [PacketIndex(2)]
        public byte Unknow1 { get; set; } // TODO : Find it

        [PacketIndex(3)]
        public byte Unknow2 { get; set; } // TODO : Find it

        [PacketIndex(4)]
        public byte Unknow3 { get; set; } // TODO : Find it

        [PacketIndex(5)]
        public byte DrawItemsCount { get; set; }

        [PacketIndex(6)]
        public short MonsterKilled { get; set; }

        [PacketIndex(7)]
        public byte RemainingNpc { get; set; }

        [PacketIndex(8)]
        public short RoomsVisited { get; set; }

        [PacketIndex(9)]
        public bool IsAllMonstersKilled { get; set; }

        [PacketIndex(10)]
        public bool IsNoNpcDead { get; set; }

        [PacketIndex(11)]
        public byte Unknow4 { get; set; } // TODO : Find it

        [PacketIndex(12)]
        public byte Unknow5 { get; set; } // TODO : Find it
    }
}
