using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("remove")]
    public class RemovePacket : IPacket
    {
        [PacketIndex(0)]
        public EquipmentType InventorySlot { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }
    }
}