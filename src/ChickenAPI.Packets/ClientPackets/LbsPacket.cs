using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets
{
    [PacketHeader("lbs")]
    public class LbsPacket : IPacket
    {
        [PacketIndex(0)]
        public int Type { get; set; }
    }
}