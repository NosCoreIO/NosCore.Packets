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
    [PacketHeader("scr", Scope.InGame)]
    public class ScrPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Unknow1 { get; set; }

        [PacketIndex(1)]
        public int Unknow2 { get; set; }

        [PacketIndex(2)]
        public int Unknow3 { get; set; }

        [PacketIndex(3)]
        public int Unknow4 { get; set; }

        [PacketIndex(4)]
        public int Unknow5 { get; set; }

        [PacketIndex(5)]
        public int Unknow6 { get; set; }
    }
}