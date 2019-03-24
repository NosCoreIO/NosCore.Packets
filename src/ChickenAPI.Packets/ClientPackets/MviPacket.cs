using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("mvi")]
    public class MviPacket : IPacket
    {
        [PacketIndex(0)]
        public PocketType InventoryType { get; set; }

        [PacketIndex(1)]
        public short Slot { get; set; }

        [PacketIndex(2)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        public byte DestinationSlot { get; set; }
    }
}