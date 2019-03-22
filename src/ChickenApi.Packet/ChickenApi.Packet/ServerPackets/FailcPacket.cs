using ChickenApi.Packet.Enumerations;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("failc")]
    public class FailcPacket : IPacket
    {
        [PacketIndex(0)]
        public LoginFailType Type { get; set; }
    }
}