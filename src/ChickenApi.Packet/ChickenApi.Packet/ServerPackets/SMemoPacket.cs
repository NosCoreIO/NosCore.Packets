using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("s_memo")]
    public class SMemoPacket : IPacket
    {
        [PacketIndex(0)]
        public SMemoType Type { get; set; }

        [PacketIndex(1, SerializeToEnd = true)]
        public string Message { get; set; }
    }
}