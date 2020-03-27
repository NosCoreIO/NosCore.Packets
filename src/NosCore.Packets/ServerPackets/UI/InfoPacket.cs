using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("info")]
    public class InfoPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? Message { get; set; }
    }
}