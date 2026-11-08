//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("pdelay", Scope.InGame)]
    public class PdelayPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Delay { get; set; }

        [PacketIndex(1)]
        public DelayPacketType Type { get; set; }

        [PacketIndex(2)]
        public IPacket? Packet { get; set; }
    }
}