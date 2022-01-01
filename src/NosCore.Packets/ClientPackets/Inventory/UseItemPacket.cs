//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("u_i", Scope.InGame)]
    public class UseItemPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [Range(0, 9)]
        [PacketIndex(2)]
        public PocketType Type { get; set; }

        [PacketIndex(3)]
        public short Slot { get; set; }

        [PacketIndex(4)]
        public short Mode { get; set; }

        [PacketIndex(5)]
        public short? Parameter { get; set; }
    }
}