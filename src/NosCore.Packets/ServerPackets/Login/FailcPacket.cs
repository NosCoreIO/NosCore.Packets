using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Login
{
    [PacketHeader("failc")]
    public class FailcPacket : PacketBase
    {
        [PacketIndex(0)]
        public LoginFailType Type { get; set; }
    }
}