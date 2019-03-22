using ChickenApi.Packet.Attributes;
using ChickenApi.Packet.Enumerations;
using ChickenApi.Packet.Interfaces;

namespace ChickenApi.Packet.ServerPackets
{
    [PacketHeader("failc")]
    public class FailcPacket : IPacket
    {
        [PacketIndex(0)]
        public LoginFailType Type { get; set; }
    }
}