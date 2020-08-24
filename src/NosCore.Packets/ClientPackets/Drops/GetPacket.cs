//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Drops
{
    [PacketHeader("get")]
    public class GetPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType PickerType { get; set; }

        [PacketIndex(1)]
        public long PickerId { get; set; }

        [PacketIndex(2)]
        public long VisualId { get; set; }
    }
}