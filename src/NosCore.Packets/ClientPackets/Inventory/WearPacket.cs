//  __  _  __    __   ___ __  ___ ___
// |  \| |/__\ /' _/ / _//__\| _ \ __|
// | | ' | \/ |`._`.| \_| \/ | v / _|
// |_|\__|\__/ |___/ \__/\__/|_|_\___|
// -----------------------------------

using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Inventory
{
    [PacketHeader("wear")]
    public class WearPacket : PacketBase, IWorldPacket
    {
        [PacketIndex(0)]
        public byte InventorySlot { get; set; }

        [PacketIndex(1)]
        public PocketType Type { get; set; }
    }
}