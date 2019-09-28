using ChickenAPI.Packets.Attributes;

namespace ChickenAPI.Packets.ClientPackets.Warehouse
{
    [PacketHeader("withdraw")]
    public class WithdrawPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public short Amount { get; set; }

        [PacketIndex(2)]
        public bool PetBackpack { get; set; }
    }
}