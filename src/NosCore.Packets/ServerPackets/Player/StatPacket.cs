//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("stat", Scope.InGame)]
    public class StatPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Hp { get; set; }

        [PacketIndex(1)]
        public double HpMaximum { get; set; }

        [PacketIndex(2)]
        public int Mp { get; set; }

        [PacketIndex(3)]
        public double MpMaximum { get; set; }

        [PacketIndex(4)]
        public int Unknown { get; set; } //TODO to find

        [PacketIndex(5)]
        public double Option { get; set; }
    }
}