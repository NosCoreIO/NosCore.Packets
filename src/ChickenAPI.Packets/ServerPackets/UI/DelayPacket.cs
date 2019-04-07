using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets.UI
{
    [PacketHeader("delay")]
    public class DelayPacket : IPacket
    {
        [PacketIndex(0)]
        public short Delay { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public IPacket Packet { get; set; }
    }
}