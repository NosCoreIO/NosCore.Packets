using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
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