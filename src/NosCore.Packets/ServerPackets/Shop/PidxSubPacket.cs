//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.Shop
{
    [PacketHeader("pidx_sub_packet")]
    public class PidxSubPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public bool IsGrouped { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }
    }
}