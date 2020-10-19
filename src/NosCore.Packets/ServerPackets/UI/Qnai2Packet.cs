//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.Collections.Generic;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("qnai2")]
    public class Qnai2Packet : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public IPacket? YesPacket { get; set; }

        [PacketIndex(1)]
        public Game18NConstString Question { get; set; }

        [PacketIndex(2)]
        public byte FirstArgument { get; set; }

        [PacketIndex(3)]
        public byte SecondArgument { get; set; }

    }
}