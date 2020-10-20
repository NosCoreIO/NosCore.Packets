//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Login
{
    public class ClientVersionSubPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Major { get; set; }

        [PacketIndex(1)]
        public byte Minor { get; set; }

        [PacketIndex(2)]
        public short Fix { get; set; }

        [PacketIndex(3)]
        public short SubFix { get; set; }
    }
}