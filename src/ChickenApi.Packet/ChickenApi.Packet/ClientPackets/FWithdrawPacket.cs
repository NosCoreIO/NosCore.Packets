namespace ChickenApi.Packet.ClientPackets
{
    [PacketHeader("f_withdraw")]
    public class FWithdrawPacket : IPacket
    {
        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public short Amount { get; set; }

        [PacketIndex(2)]
        public byte? Unknown { get; set; }
    }
}