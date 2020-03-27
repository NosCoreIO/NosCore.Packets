using NosCore.Packets.Attributes;

namespace NosCore.Packets.ClientPackets.Movement
{
    [PacketHeader("pulse")]
    public class PulsePacket : PacketBase
    {
        [PacketIndex(0)]
        public int Tick { get; set; }
    }
}