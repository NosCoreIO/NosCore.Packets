using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.Login
{
    [PacketHeader("failc")]
    public class FailcPacket : IPacket
    {
        [PacketIndex(0)]
        public LoginFailType Type { get; set; }
    }
}