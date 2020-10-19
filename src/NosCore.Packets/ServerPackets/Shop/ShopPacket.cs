//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("shop")]
    public class ShopPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public long ShopId { get; set; }

        [PacketIndex(3)]
        public byte MenuType { get; set; }

        [PacketIndex(4, IsOptional = true)]
        public byte? ShopType { get; set; }

        [PacketIndex(5, IsOptional = true)]
        public string? Name { get; set; }
    }
}