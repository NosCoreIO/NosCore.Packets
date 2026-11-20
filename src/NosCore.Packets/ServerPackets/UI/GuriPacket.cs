//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("guri", Scope.InGame, AllowDuplicateHeader = true)]
    public class GuriPacket : PacketBase
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; }

        [PacketIndex(1)]
        public uint Argument { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public uint? SecondArgument { get; set; }

        // Most guri lines carry it; one that ends after its argument, such as the freeze timer's, leaves it out.
        [PacketIndex(3, IsOptional = true)]
        public long? EntityId { get; set; } = 0;

        [PacketIndex(4, IsOptional = true)]
        public uint? Value { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public uint? SecondValue { get; set; }
    }
}