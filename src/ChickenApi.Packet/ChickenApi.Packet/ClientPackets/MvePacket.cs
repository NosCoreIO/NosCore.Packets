using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("mve")]
    public class MvePacket : IPacket
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