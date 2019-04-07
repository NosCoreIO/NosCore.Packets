using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Enumerations;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ClientPackets.Mates
{
    [PacketHeader("psl")]
    public class PslPacket : IPacket
    {
        [PacketIndex(0)]
        public PslPacketType Type { get; set; }
    }
}