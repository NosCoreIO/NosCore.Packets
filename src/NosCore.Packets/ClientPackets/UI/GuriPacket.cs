//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.UI
{
    [PacketHeader("guri")]
    public class GuriPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public GuriPacketType Type { get; set; }

        [PacketIndex(1)]
        public int? Argument { get; set; }

        [PacketIndex(2, IsOptional = true)]
        public long? VisualId { get; set; }

        [PacketIndex(3, IsOptional = true)]
        public long? Data { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public string? Value { get; set; }
    }
}