using NosCore.Packets.Attributes;
using NosCore.Packets.Interfaces;

namespace NosCore.Packets.ServerPackets.UI
{
    [PacketHeader("delay")]
    public class DelayPacket : PacketBase
    {
        [PacketIndex(0)]
        public short Delay { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public IPacket? Packet { get; set; }
    }
}