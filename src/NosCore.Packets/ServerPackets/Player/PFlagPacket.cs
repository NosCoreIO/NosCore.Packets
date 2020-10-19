//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("pflag")]
    public class PFlagPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public VisualType EntityType { get; set; }

        [PacketIndex(1)]
        public long EntityId { get; set; }

        [PacketIndex(2)]
        public long ShopId { get; set; }
    }
}