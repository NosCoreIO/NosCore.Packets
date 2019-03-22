namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("modal")]
    public class ModalPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Type { get; set; } //TODO: find modal types

        [PacketIndex(1, SerializeToEnd = true)]
        public string Message { get; set; }
    }
}