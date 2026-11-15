//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;
using NosCore.Shared.Enumerations;

namespace NosCore.Packets.ServerPackets.Chats
{
    [PacketHeader("sayitemt", Scope.InGame)]
    public class SayItemtPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType VisualType { get; set; }

        [PacketIndex(1)]
        public long VisualId { get; set; }

        [PacketIndex(2)]
        public byte OratorSlot { get; set; }

        [PacketIndex(3)]
        public byte Type { get; set; }

        [PacketIndex(4)]
        public short ItemVNum { get; set; }

        [PacketIndex(5)]
        public string? VisualName { get; set; }

        /// <summary>
        /// The client writes the item's name where the message holds <c>{%s}</c>.
        /// </summary>
        [PacketIndex(6, EscapeSpaces = true, SpaceEscape = "|")]
        public string? Message { get; set; }

        /// <summary>
        /// The packet the item's own info window gets (e_info, slinfo or IconInfo), written inline.
        /// </summary>
        [PacketIndex(7, RemoveHash = true)]
        public IPacket? ItemInfo { get; set; }
    }
}
