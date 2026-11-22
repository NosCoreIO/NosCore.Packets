using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ClientPackets.Instance
{
    [PacketHeader("wreq", Scope.InGame)]
    public class WreqPacket : PacketBase
    {
        // Left out when the player steps onto a time-space stone.
        [PacketIndex(0, IsOptional = true)]
        public WreqPacketType? Value { get; set; }

        [PacketIndex(1, IsOptional = true)]
        public long? Param { get; set; }
    }
}
