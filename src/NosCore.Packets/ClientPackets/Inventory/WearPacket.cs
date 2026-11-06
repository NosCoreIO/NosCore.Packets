//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("wear", Scope.InGame)]
    public class WearPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte InventorySlot { get; set; }

        /// <summary>0 for the character, otherwise the partner's slot plus one.</summary>
        [PacketIndex(1)]
        public byte PartnerSlot { get; set; }
    }
}