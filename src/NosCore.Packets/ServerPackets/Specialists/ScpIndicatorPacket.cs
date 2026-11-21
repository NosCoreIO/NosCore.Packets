using NosCore.Packets.Attributes;
using NosCore.Packets.Enumerations;

namespace NosCore.Packets.ServerPackets.Specialists
{
    // Set while the worn specialist drains its points in combat: the client pulses both point gauges until
    // it is cleared.
    [PacketHeader("scp", Scope.InGame)]
    public class ScpIndicatorPacket : PacketBase
    {
        [PacketIndex(0)]
        public bool IsDraining { get; set; }
    }
}
