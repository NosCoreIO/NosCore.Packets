using NosCore.Packets.Attributes;

namespace NosCore.Packets.ServerPackets.Player
{
    [PacketHeader("tit")]
    public class TitPacket : PacketBase
    {
        [PacketIndex(0)]
        public string? ClassType { get; set; }

        [PacketIndex(1)]
        public string? Name { get; set; }
    }
}