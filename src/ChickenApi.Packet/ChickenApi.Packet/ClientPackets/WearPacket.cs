using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("wear")]
    public class WearPacket : IPacket
    {
        [PacketIndex(0)]
        public byte InventorySlot { get; set; }

        [PacketIndex(1)]
        public PocketType Type { get; set; }
    }
}