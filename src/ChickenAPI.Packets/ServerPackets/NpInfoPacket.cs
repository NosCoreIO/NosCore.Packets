using ChickenAPI.Packets.Attributes;
using ChickenAPI.Packets.Interfaces;

namespace ChickenAPI.Packets.ServerPackets
{
    [PacketHeader("npinfo")]
    public class NpInfoPacket : IPacket
    {
        [PacketIndex(0)]
        public byte Page { get; set; }
    }
}