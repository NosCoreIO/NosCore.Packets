//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ClientPackets.Shops
{
    [PacketHeader("buy", Scope.InGame)]
    public class BuyPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [Range(0, short.MaxValue)]
        [PacketIndex(2)]
        public short Slot { get; set; }

        // A skill shop sends the skill vnum as the slot and no amount.
        [PacketIndex(3, IsOptional = true)]
        [Range(1, short.MaxValue)]
        public short? Amount { get; set; }
    }
}