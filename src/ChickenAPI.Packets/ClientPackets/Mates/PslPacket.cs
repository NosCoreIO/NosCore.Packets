using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;

namespace ChickenAPI.Packets.ClientPackets.Mates
{
    [PacketHeader("psl")]
    public class PslPacket : PacketBase
    {
        [PacketIndex(0)]
        public PslPacketType Type { get; set; }
    }
}