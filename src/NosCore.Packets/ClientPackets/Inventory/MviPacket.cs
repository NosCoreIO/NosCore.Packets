//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using System.ComponentModel.DataAnnotations;
using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("mvi", Scope.InGame)]
    public class MviPacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType InventoryType { get; set; }

        [Range(0, short.MaxValue)]
        [PacketIndex(1)]
        public short Slot { get; set; }

        [Range(1, short.MaxValue)]
        [PacketIndex(2)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        public byte DestinationSlot { get; set; }
    }
}