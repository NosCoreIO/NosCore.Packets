using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("f_deposit")]
    public class FDepositPacket : IPacket
    {
        [PacketIndex(0)]
        public PocketType Inventory { get; set; }

        [PacketIndex(1)]
        public byte Slot { get; set; }

        [PacketIndex(2)]
        public short Amount { get; set; }

        [PacketIndex(3)]
        public byte NewSlot { get; set; }

        [PacketIndex(4)]
        public byte? Unknown { get; set; }
    }
}