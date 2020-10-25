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
    [PacketHeader("guri", Scope.InGame)]
    public class GuriPacket : PacketBase
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; }

        [PacketIndex(1)]
        public uint Argument { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public uint? SecondArgument { get; set; }

        [PacketIndex(3)]
        public long EntityId { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public uint? Value { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public uint? SecondValue { get; set; }
    }
}