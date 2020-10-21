//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("mve", Scope.InGame)]
    public class MvePacket : PacketBase
    {
        [PacketIndex(0)]
        public PocketType InventoryType { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        public PocketType DestinationInventoryType { get; set; }

        [PacketIndex(3)]
        public short DestinationSlot { get; set; }
    }
}