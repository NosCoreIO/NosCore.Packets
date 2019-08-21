using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Inventory
{
    [PacketHeader("wear")]
    public class WearPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte InventorySlot { get; set; }

        [PacketIndex(1)]
        public PocketType Type { get; set; }
    }
}