using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
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