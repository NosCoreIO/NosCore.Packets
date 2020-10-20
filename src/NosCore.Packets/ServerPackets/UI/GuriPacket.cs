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
    [PacketHeader("guri", Scope.InGame | Scope.InExchange)]
    public class GuriPacket : PacketBase
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; }

        [PacketIndex(1)]
        public uint Unknown { get; set; } // seems to be a visual type or something

        [PacketIndex(2)]
        public long EntityId { get; set; }

        [PacketIndex(3)]
        public uint Value { get; set; }
    }
}