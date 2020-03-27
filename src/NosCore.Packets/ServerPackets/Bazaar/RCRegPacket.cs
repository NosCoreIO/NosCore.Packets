using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Bazaar
{
    [PacketHeader("rc_reg")]
    public class RCRegPacket : PacketBase
    {
        [PacketIndex(0)]
        public VisualType Type { get; set; }
    }
}