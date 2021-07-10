using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("wreq", Scope.InGame)]
    public class WreqPacket : PacketBase
    {
        [PacketIndex(0)]
        public WreqPacketType Value { get; set; }

        [PacketIndex(1)]
        public long? Param { get; set; }
    }
}
