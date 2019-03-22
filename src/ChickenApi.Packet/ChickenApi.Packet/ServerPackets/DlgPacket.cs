namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("dlg")]
    public class DlgPacket : IPacket
    {
        [PacketIndex(0, IsReturnPacket = true)]
        public IPacket YesPacket { get; set; }

        [PacketIndex(1, IsReturnPacket = true)]
        public IPacket NoPacket { get; set; }

        [PacketIndex(2, SerializeToEnd = true)]
        public string Question { get; set; }
    }
}