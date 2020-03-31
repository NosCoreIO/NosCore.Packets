using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets
{
    [PacketHeader("lbs")]
    public class LbsPacket : PacketBase
    {
        [PacketIndex(0)]
        public int Type { get; set; }
    }
}