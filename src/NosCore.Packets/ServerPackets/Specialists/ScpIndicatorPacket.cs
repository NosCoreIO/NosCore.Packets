using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Specialists
{
    [PacketHeader("scp", Scope.InGame)]
    public class ScpIndicatorPacket : PacketBase
    {
        [PacketIndex(0)]
        public byte Value { get; set; }
    }
}
