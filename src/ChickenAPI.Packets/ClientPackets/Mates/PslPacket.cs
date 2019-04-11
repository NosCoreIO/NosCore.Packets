using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Mates
{
    [PacketHeader("psl")]
    public class PslPacket : PacketBase
    {
        [PacketIndex(0)]
        public PslPacketType Type { get; set; }
    }
}